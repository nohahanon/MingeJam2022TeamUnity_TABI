using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class communicationManager : MonoBehaviour
{
    public string npcName;
    public string[] serifs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player" || this.transform.root.gameObject.GetComponent<parentCommunicationManager>().canTalk == false) return;
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().communicationPanel.SetActive(true);
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().nameInCommunicationPanel.text = npcName;
        StartCoroutine(communication());
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().canTalk = false;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        // 次のためにtextを初期化する
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().nameInCommunicationPanel.text = "";
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().serifsInCommunicationPanel.text = "";
        // panelを非表示にする
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().communicationPanel.SetActive(false);
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().canTalk = true;
    }
    IEnumerator communication()
    {
        int i, j;
        int n = 13;
        for (i = 0; i < serifs.Length; i++)
        {
            for (j = 0; j < serifs[i].Length; j++)
            {
                if (j % n == 0 && j != 0)
                {
                    yield return new WaitUntil(() => Input.anyKeyDown);
                    this.transform.root.gameObject.GetComponent<parentCommunicationManager>().serifsInCommunicationPanel.text = "";
                }
                this.transform.root.gameObject.GetComponent<parentCommunicationManager>().serifsInCommunicationPanel.text += serifs[i][j];
                yield return new WaitForSeconds(this.transform.root.gameObject.GetComponent<parentCommunicationManager>().textSpeed);
            }
            yield return new WaitUntil(() => Input.anyKeyDown);
            this.transform.root.gameObject.GetComponent<parentCommunicationManager>().serifsInCommunicationPanel.text = "";
        }
        this.transform.root.gameObject.GetComponent<parentCommunicationManager>().communicationPanel.SetActive(false);
    }
}

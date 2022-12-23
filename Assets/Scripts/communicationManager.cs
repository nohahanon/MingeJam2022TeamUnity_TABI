using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class communicationManager : MonoBehaviour
{
    private GameObject communicationPanel;
    private Text nameInCommunicationPanel, serifsInCommunicationPanel;
    public string npcName;
    public string[] serifs;
    // Start is called before the first frame update
    void Start()
    {
        communicationPanel = GameObject.FindWithTag("communicationPanel");
        nameInCommunicationPanel = GameObject.FindWithTag("nameInCommunicationPanel").GetComponent<Text>();
        serifsInCommunicationPanel = GameObject.FindWithTag("serifsInCommunicationPanel").GetComponent<Text>();
        communicationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        communicationPanel.SetActive(true);
        nameInCommunicationPanel.text = npcName;
        StartCoroutine(communication());
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        // 次のためにtextを初期化する
        nameInCommunicationPanel.text = "";
        serifsInCommunicationPanel.text = "";
        // panelを非表示にする
        communicationPanel.SetActive(false);
    }
    IEnumerator communication()
    {
        int i, j;
        for (i = 0; i < serifs.Length; i++)
        {
            for (j = 0; j < serifs[i].Length; j++)
            {
                serifsInCommunicationPanel.text += serifs[i][j];
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitUntil(() => Input.anyKeyDown);
            serifsInCommunicationPanel.text = "";
        }
        communicationPanel.SetActive(false);
    }
}

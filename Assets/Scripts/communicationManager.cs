using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class communicationManager : MonoBehaviour
{
    private parentCommunicationManager _parentCommunicationManager;
    public string npcName;
    public string[] serifs;
    private bool bye = false;
    // Start is called before the first frame update
    void Start()
    {
        _parentCommunicationManager = this.transform.root.gameObject.GetComponent<parentCommunicationManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        // object(NPC, keyItem)がt"Player"との接触以外　または　既に誰かと話しているときは会話を進めない
        if (other.gameObject.tag != "Player" || _parentCommunicationManager.canTalk == false) return;
        // 黒い会話パネルを表示させて
        _parentCommunicationManager.communicationPanel.SetActive(true);
        // もしあるなら名前欄に文字列代入
        _parentCommunicationManager.nameInCommunicationPanel.text = npcName;
        // ここから誰かの話しかけられる範囲に侵入してもそれはブロックされるようにする
        _parentCommunicationManager.canTalk = false;
        // セリフ表示コルーチン開始
        StartCoroutine(communication());
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;

        // 次のためにtextを初期化する
        _parentCommunicationManager.nameInCommunicationPanel.text = "";
        _parentCommunicationManager.serifsInCommunicationPanel.text = "";
        // panelを非表示にする
        _parentCommunicationManager.communicationPanel.SetActive(false);
        // もう話しかけていいよ、とする
        _parentCommunicationManager.canTalk = true;
    }
    IEnumerator communication()
    {
        int i, j;
        int n = 15;
        for (i = 0; i < serifs.Length; i++)
        {
            for (j = 0; j < serifs[i].Length; j++)
            {
                if (j % n == 0 && j != 0)
                {
                    yield return new WaitUntil(() => Input.anyKeyDown);
                    _parentCommunicationManager.serifsInCommunicationPanel.text = "";
                }
                _parentCommunicationManager.serifsInCommunicationPanel.text += serifs[i][j];
                yield return new WaitForSeconds(_parentCommunicationManager.textSpeed);
            }
            yield return new WaitUntil(() => Input.anyKeyDown);
            _parentCommunicationManager.serifsInCommunicationPanel.text = "";
        }
        _parentCommunicationManager.communicationPanel.SetActive(false);
    }
}

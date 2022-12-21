using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manageKeyItems : MonoBehaviour
{

    public Text _text;
    public GameObject[] keyItems;
    private int numOfItem, cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        numOfItem = keyItems.Length;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "keyItem")
        {
            if ((cnt + 1) == numOfItem) _text.text = "クリア!";
            else
                _text.text = (++cnt) + "個目みつけた！あと" + (numOfItem - cnt) + "個！";
            other.gameObject.SetActive(false);
        }
    }
}

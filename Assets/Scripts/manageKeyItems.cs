using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageKeyItems : MonoBehaviour
{
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
            if ((cnt + 1) == numOfItem) Debug.Log("くりあ！");
            else
                Debug.Log((++cnt) + "個目みつけた！あと" + (numOfItem - cnt) + "個！");
            other.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTitleKeyDownAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t")) FadeManager.Instance.LoadScene("title", 1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterEachWorldKeyDownAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g")) FadeManager.Instance.LoadScene("grassWorld", 1.0f);
        else if (Input.GetKeyDown("s")) FadeManager.Instance.LoadScene("snowWorld", 1.0f);
        else if (Input.GetKeyDown("d")) FadeManager.Instance.LoadScene("desertWorld", 1.0f);
    }
}

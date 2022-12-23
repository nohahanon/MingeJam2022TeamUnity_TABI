using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTitleButtonAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        // SceneManeger.LoadScene("desertWorld");  // FIXME
        FadeManager.Instance.LoadScene("title", 1.0f);
    }
}

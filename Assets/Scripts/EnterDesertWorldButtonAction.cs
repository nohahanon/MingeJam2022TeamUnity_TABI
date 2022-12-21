using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterDesertWorldButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        // SceneManeger.LoadScene("desertWorld");  // FIXME
        FadeManager.Instance.LoadScene("desertWorld", 1.0f);
    }
}

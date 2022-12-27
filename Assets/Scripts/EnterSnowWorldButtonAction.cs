using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterSnowWorldButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        // SceneManeger.LoadScene("snowWorld");  // FIXME
        FadeManager.Instance.LoadScene("snowWorld", 1.0f);
    }
}

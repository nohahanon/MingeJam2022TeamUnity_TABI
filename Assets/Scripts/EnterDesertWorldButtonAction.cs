using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterDesertWorldButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("EnterDesertWorldButtonAction");  // TODO: Remove this line
        SceneManeger.LoadScene("grassWorld");  // FIXME
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterSnowWorldButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("EnterSnowWorldButtonAction");  // TODO: Remove this line
        SceneManeger.LoadScene("snowWorld");
    }
}

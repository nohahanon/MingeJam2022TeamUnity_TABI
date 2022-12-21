using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterGrassWorldButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("EnterGrassWorldButtonAction");  // TODO: Remove this line
        SceneManeger.LoadScene("grassWorld");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterWorldSelectionButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("EnterWorldSelectionButtonAction");  // TODO: Remove this line
        SceneManeger.LoadScene("WorldSelection");  // FIXME
    }
}

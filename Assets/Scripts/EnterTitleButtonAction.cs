using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTitleButtonAction : MonoBehaviour
{
    public void OnClick()
    {
        FadeManager.Instance.LoadScene("title", 1.0f);
    }
}

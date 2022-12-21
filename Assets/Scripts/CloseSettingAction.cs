using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSettingAction : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingPanel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CloseSettingAction Start");  // TODO: Remove this line
    }
    
    public void OnClick()
    {
        Debug.Log("CloseBagAction OnClick");  // TODO: Remove this line
        _settingPanel.SetActive(false);
    }
}

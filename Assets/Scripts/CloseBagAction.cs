using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBagAction : MonoBehaviour
{
    [SerializeField]
    private GameObject _bagPanel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CloseBagAction Start");  // TODO: Remove this line
    }
    
    public void OnClick()
    {
        Debug.Log("CloseBagAction OnClick");  // TODO: Remove this line
        _bagPanel.SetActive(false);
    }
}

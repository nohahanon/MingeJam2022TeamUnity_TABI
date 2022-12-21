using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBagAction : MonoBehaviour
{
    [SerializeField]
    private GameObject _bagPanel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("OpenBagAction Start");  // TODO: Remove this line
    }

    public void OnClick()
    {
        Debug.Log("OpenBagAction OnClick");  // TODO: Remove this line
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterWorldSelectionKeyDownAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("EnterWorldSelectionButtonAction");  // TODO: Remove this line
            SceneManeger.LoadScene("WorldSelection");  // FIXME
        }
    }
}

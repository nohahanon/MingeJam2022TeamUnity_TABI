using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManeger = UnityEngine.SceneManagement.SceneManager;

public class EnterWorldSelectionKeyDownAction : MonoBehaviour
{
    public GameObject titleBoard, selectBoard;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            // SceneManeger.LoadScene("WorldSelection");  // FIXME
            selectBoard.SetActive(true);
            titleBoard.SetActive(false);
        }
    }
}

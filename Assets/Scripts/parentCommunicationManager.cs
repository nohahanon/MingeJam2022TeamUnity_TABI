using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parentCommunicationManager : MonoBehaviour
{
    public bool canTalk = true;
    public GameObject communicationPanel;
    public Text nameInCommunicationPanel, serifsInCommunicationPanel;
    public float textSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        communicationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioListener = UnityEngine.AudioListener;

public class VolumeToggleAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("VolumeToggleAction Start");  // TODO: Remove this line
    }

    public void OnClick()
    {
        Debug.Log("VolumeToggleAction OnClick");  // TODO: Remove this line
        ToggleMute();
    }

    void ToggleMute()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}

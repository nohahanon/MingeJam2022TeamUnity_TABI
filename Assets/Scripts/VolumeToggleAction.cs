using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioListener = UnityEngine.AudioListener;
using Image = UnityEngine.UI.Image;
using Sprite = UnityEngine.Sprite;

public class VolumeToggleAction : MonoBehaviour
{
    [SerializeField]
    private Image _iconHolder;
    [SerializeField]
    private Sprite _muteIcon;
    [SerializeField]
    private Sprite _unmuteIcon;

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
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            _iconHolder.sprite = _unmuteIcon;
        }
        else
        {
            AudioListener.volume = 0;
            _iconHolder.sprite = _muteIcon;
        }
    }
}

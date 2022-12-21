using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class skyChanger : MonoBehaviour
{
    public Light _light;
    private float time = 0f;
    private float halfDayTime = 150f;
    Color mor = new Color(230f / 255f, 1f, 1f), eve = new Color(1f, 165f / 255f, 1f); // 朝と夜にそれぞれのライトの色にします

    // Start is called before the first frame update
    void Start()
    {
        // ライトの色と明るさ, skyboxを朝のものにする
        _light.color = mor;
        _light.intensity = 1f;
        RenderSettings.skybox.SetFloat("_CubemapTransition", 0f);
        StartCoroutine(changeSky());
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > halfDayTime)
        {
            StartCoroutine(changeSky());
            time = 0f;
        }

    }
    IEnumerator changeSky()
    {
        float rDiff = 1f - (230f / 255f), gDiff = 1f - (165f / 255f);
        // 朝から夜
        if (RenderSettings.skybox.GetFloat("_CubemapTransition") < 0.1f)
        {
            while (RenderSettings.skybox.GetFloat("_CubemapTransition") < 1f)
            {
                // 暗くして
                _light.intensity -= 0.001f;
                // 色を変えて
                _light.color = new Color(_light.color.r + (rDiff) / 1000, _light.color.g - (gDiff) / 1000, 1f);
                // skyboxをじわじわ夜のものに変えていく
                RenderSettings.skybox.SetFloat("_CubemapTransition", RenderSettings.skybox.GetFloat("_CubemapTransition") + 0.001f);
                yield return new WaitForSeconds(0.01f);
            }
        } // 夜から朝
        else
        {
            while (0f < RenderSettings.skybox.GetFloat("_CubemapTransition"))
            {
                // 明るくして
                _light.intensity += 0.001f;
                // 色を変えて
                _light.color = new Color(_light.color.r - (rDiff) / 1000, _light.color.g + (gDiff) / 1000, 1f);
                // skyboxをじわじわ朝のものに変えていく
                RenderSettings.skybox.SetFloat("_CubemapTransition", RenderSettings.skybox.GetFloat("_CubemapTransition") - 0.001f);
                yield return new WaitForSeconds(0.01f);
            }
        }
        time = 0f;
    }
}

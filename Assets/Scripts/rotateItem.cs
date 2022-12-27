using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class rotateItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.DORotate(endValue: new Vector3(0, 360f, 0), duration: 1.0f, mode: RotateMode.FastBeyond360);
    }
}

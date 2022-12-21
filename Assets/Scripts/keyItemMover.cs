using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class keyItemMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DORotate(new Vector3(0f, 90f), 1f);
        this.transform.DOLocalJump(Vector3.one, 30, 10, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

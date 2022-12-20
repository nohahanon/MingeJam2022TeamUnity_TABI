using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class makeMove : MonoBehaviour
{
    public GameObject[] ankers;
    private float timePerLoop = 200f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOPath(makePath(), timePerLoop, PathType.CatmullRom).SetLoops(10, LoopType.Yoyo); ;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private Vector3[] makePath()
    {
        // 設置したanker役のobjectからpositionを抜き取りpath用の配列を返します
        int i, idx = 0;
        int ankersLength = ankers.Length;
        Vector3[] path = new Vector3[ankersLength];
        bool[] check = new bool[ankersLength];
        for (i = 0; i < ankersLength; i++) check[i] = false;// false:未使用, true:使用済
        for (i = 0; i < ankersLength; i++)
        {
            while (check[idx] == true) idx = (idx + 1) % ankersLength;
            check[idx] = true;
            path[i] = ankers[idx].transform.position;
            path[i].y += Random.Range(3, 20);
        }
        return path;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerater : MonoBehaviour
{
    // 注意: 常にこれを動作させると重くなります。何も置かれていないsceneで最初の一回に実行して出来上がったオブジェクトをコピーして持ち帰るためだけのものです。
    // 使い方: ヒエラルキに空オブジェクトを設置してこのスクリプトをアタッチして再生してください。
    // terrainが10*10で生成されます。
    public GameObject[] grounds;
    // Start is called before the first frame update
    void Start()
    {
        int i, j, distance = 25; // distance = 30で均等に並ぶが、terrainの角が丸いため若干の隙間が生じる。よって25に設定した。
        int[] args = { 0, 90, -90, 180 };
        Vector3 pos;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                pos = new Vector3(this.transform.position.x + i * distance, this.transform.position.y, this.transform.position.z + j * distance);
                Instantiate(grounds[Random.Range(0, grounds.Length)], pos, Quaternion.Euler(0, args[Random.Range(0, 4)], 0), this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGenerater : MonoBehaviour
{
    // 使い方: ヒエラルキにplants(適当な空オブジェクト)を置き、transformをresetしてからこのスクリプトをアタッチして実行します。(クラス変数plants[]に配置したいオブジェクトを予め置いてください)するとGroundGenerater.csで配置したterrainに収まるように植物などを配置してくれます。
    // 実行するのは最初の一回だけでいいです。その実行からオブジェクトたちをコピーして持ち帰ってください。
    // 注意: このスクリプトでしていることは割と重い処理なので基本activeはfalseにしてください。
    public GameObject[] plants;
    // Start is called before the first frame update
    void Start()
    {
        int i, j, k;
        Vector3 pos;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                for (k = 0; k < 20; k++)
                {
                    pos = new Vector3(this.transform.position.x + Random.Range(-10, 220), this.transform.position.y + 0.15f, this.transform.position.z + Random.Range(-10, 220));
                    Instantiate(plants[Random.Range(0, plants.Length)], pos, Quaternion.Euler(-90, Random.Range(0, 180), 0), this.transform);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

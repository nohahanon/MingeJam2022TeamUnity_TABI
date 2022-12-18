using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGenerater : MonoBehaviour
{
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

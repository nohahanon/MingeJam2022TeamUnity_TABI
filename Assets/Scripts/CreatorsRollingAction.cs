using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreatorsRollingAction : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI[] Creators;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {     
        this.RotateCreatorHolder();
        this.RotateEveryCreatorClockwise();
    }

    void RotateEveryCreatorClockwise()
    {
        foreach (var creator in this.Creators)
        {
            creator.transform.Rotate(0, 0, -1);
        }
    }

    void RotateCreatorHolder()
    {
        this.transform.Rotate(0, 0, 1);
    }
}

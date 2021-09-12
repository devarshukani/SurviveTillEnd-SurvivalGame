using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reducesize : MonoBehaviour
{
    int i = 0;
    void Update()
    {
        i++;
        if (i == 100)
        {
            i = 0;
            transform.localScale -= new Vector3(2, 0, 2);
        }
    }
}

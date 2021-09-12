using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeconsumed : MonoBehaviour
{

    public Transform tr;
    public Text time;
    //public Text hs;

    int i = 0;
    int z;
    int j = 1;

    void Update()
    {
            i++;
            if (i % 1000000 == j)
            {
                j += 1;
                z = i % (1000000);
                time.text = z.ToString("0");
            }
            
    }
    
}

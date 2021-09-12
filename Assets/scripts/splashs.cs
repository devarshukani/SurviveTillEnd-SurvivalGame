using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashs : MonoBehaviour
{

    int i = 0;
    void Update()
    {
        i++;
        if(i==45)
        {
            SceneManager.LoadScene("tip1");
        }
    }
}

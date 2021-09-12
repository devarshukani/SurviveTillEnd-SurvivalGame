using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlsscript : MonoBehaviour
{
    
    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("creator");
        }
    }
}

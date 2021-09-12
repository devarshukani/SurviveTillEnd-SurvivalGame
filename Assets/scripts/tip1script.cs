using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tip1script : MonoBehaviour
{
   
    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("tip2");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creatorscript : MonoBehaviour
{
    
    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("menugame");
        }
    }
}

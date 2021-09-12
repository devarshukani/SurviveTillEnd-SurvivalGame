using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{

   // public Rigidbody rb;
    public float forwardforce = 10f;
    public float rotation_sensitivity = 60f;
    int i = 0;
    int j = 0;
    int k = 0;
    int l = 0;
    void FixedUpdate()
    {
        i++;
        if(i>250)
        {
            i = 0;          
            forwardforce += 1f;
            rotation_sensitivity += 2f;

            
        }
        

        transform.position += transform.forward * Time.deltaTime * forwardforce;

        if (Input.GetKeyUp("right"))
        {
            k = 0;
            j = 1;
        }
        if (Input.GetKeyUp("left"))
        {
            j = 0;
            k = 1;
        }
 
        if(transform.position.y <=0)
        {
            SceneManager.LoadScene("crashedfloor");
        }

        if(j==1)
        {
            transform.Rotate(0, rotation_sensitivity * Time.deltaTime, 0);
        }
        if(k==1)
        {
            transform.Rotate(0, -rotation_sensitivity * Time.deltaTime, 0);
        }
        
        

    }


    void OnCollisionEnter(Collision player)
    {
       if(player.collider.tag == "obs")
       {
        SceneManager.LoadScene("crashedbox");
       }
       

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement1 : MonoBehaviour
{

    // public Rigidbody rb;
    public Transform tr;
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

        if (Input.GetMouseButtonDown(0))
        {

            /*l += 1;
            if (l % 2 != 0)
            {
                k = 0;
                j = 1;
            }
            else
            {
                j = 0;
                k = 1;
            }*/
        }

        if (transform.position.y <=0)
        {
            SceneManager.LoadScene("crashedfloor");
        }

        if(j==1)
        {
            tr.transform.Rotate(0, -rotation_sensitivity * Time.deltaTime, 0);
        }
        if(k==1)
        {
            tr.transform.Rotate(0, rotation_sensitivity * Time.deltaTime, 0);
        }

        

    }


    void OnCollisionEnter(Collision player)
    {
       if(player.collider.tag == "obs")
       {
        SceneManager.LoadScene("crashedbox");
       }
       

    }

    public void leftrotation()
    {
        k = 0;
        j = 1;
    }

    public void rightrotation()
    {
        k = 1;
        j = 0;
    }
}

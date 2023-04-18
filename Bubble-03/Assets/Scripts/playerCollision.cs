using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{ 
    public PlayerMovement cs;

    void OnCollisionEnter(Collision c)
    {
       
        if (c.collider.tag == "Ground")
        {
            cs.jump = 0;
        }
        if(c.collider.tag == "Swap")
        {
            if (cs.right == 1) cs.right = 2;
            if (cs.left == 1) cs.left = 2;
        }
    }
}

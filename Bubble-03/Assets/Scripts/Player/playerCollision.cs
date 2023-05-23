using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{ 
    public PlayerMovement cs;
    public barrelGoesClonk barrel_cs;
    public goblinFollowPlayer goblin_cs1;
    public goblinFollowPlayer goblin_cs2;
    public float centerX = -1f;
    public float centerZ = -1f;
    public bool correctPos = false;
    public string tag;
    void OnCollisionEnter(Collision c)
    {

        tag = c.collider.tag;
        if (tag == "Ground" || tag == "Recta")
        {
            cs.jump = 0;
            
        }
        if (tag == "Recta")
        {
            centerX = c.collider.bounds.center.x;
            centerZ = c.collider.bounds.center.z;
        }
        if (tag == "Obstacle")
        {
            cs.isDead = true;
        }


    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Swap")
        {
            if (cs.right == 1) cs.right = 2;
            if (cs.left == 1) cs.left = 2;
            centerX = -1f;
            centerZ = -1f;
            correctPos = false;
        }
        if (c.tag == "BarrelEnable")
        {
            barrel_cs.barrelEnable = true;
        }
        if (c.tag =="GoblinEnable1")
        {
            goblin_cs1.goblinEnable = true;
        }
        if (c.tag == "GoblinEnable2")
        {
            goblin_cs2.goblinEnable = true;
        }

    }
}

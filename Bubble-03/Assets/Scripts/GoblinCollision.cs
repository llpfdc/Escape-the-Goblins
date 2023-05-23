using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinCollision : MonoBehaviour
{
    public goblinFollowPlayer cs;
    public float centerX = -1f;
    public float centerZ = -1f;
    public bool correctPos = false;
    public string tag;

    void OnTriggerStay(Collider c)
    {
        tag = c.GetComponent<Collider>().tag;
        if (c.tag == "Swap")
        {
            if (cs.timerSwap == 12)
            {
                if (cs.right == 1) cs.right = 2;
                if (cs.left == 1) cs.left = 2;
                centerX = -1f;
                centerZ = -1f;
                correctPos = false;
                cs.timerSwap = -1;
            }else if(cs.timerSwap != -1) ++cs.timerSwap;
        }
    }


    void OnTriggerEnter(Collider c)
    {
        tag = c.GetComponent<Collider>().tag;
        if (c.tag == "Swap")
        {
            cs.timerSwap = 0;
        }
    }
}

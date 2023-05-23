using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinFollowPlayer : MonoBehaviour
{
    public Animator anim;
    public float speed = 3.0f;
    public GoblinCollision cs;
    public bool goblinEnable;
    public int left;
    public int right;
    public int timerSwap;
    // Start is called before the first frame update
    void Start()
    {
        left = 0;
        right = 1;
        timerSwap = 0;
        goblinEnable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(goblinEnable)transform.Translate(0, 0, Time.deltaTime * speed);
        if ( cs.tag == "Swap" && left == 2)
        {
            transform.Rotate(0, -90, 0);
            left = 0;
            right = 1;
        } else if (cs.tag == "Swap" && right == 2)
        {
            transform.Rotate(0, 90, 0);
            left = 1;
            right = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelGoesClonk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        barrelEnable = false;
    }
    public float speed = 9.0f;
    public bool barrelEnable;

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0.0f, -1.0f, 0.0f);
        if(barrelEnable)transform.Translate(Time.deltaTime * speed,0.0f,0.0f);
    }
}

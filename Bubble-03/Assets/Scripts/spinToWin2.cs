using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinToWin2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool up = true;
    public float speed = 40.0f;
    // Update is called once per frame
    void Update()
    {
        if(!up){
            transform.Translate(0.0f,- Time.deltaTime * speed, 0.0f);
            
        } else{
            transform.Translate(0.0f, Time.deltaTime * speed, 0.0f);
        }
        if (transform.position.z > -111) up = true;
        if (transform.position.z < -113) up = false;
        Debug.Log(transform.position.z);
    }
}

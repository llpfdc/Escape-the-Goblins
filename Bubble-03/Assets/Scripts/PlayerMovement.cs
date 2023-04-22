using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int jump;
    public Animator anim;
    public float speed = 3f;
    public float jumpForce = 4000f;
    public float vertMov;
    public int left;
    public int right;
    public bool isDead;

    void Start()
     {
        jump = 0;
        left = 0;
        right = 1;
        isDead = false;
     }
    void Update()
    {
        
        if (!isDead)
        {
            transform.Translate(0, 0, Time.deltaTime * speed);
            anim.SetFloat("movY", Time.deltaTime * speed);
        }
        else
        {
            StartCoroutine(WaitAfterDead());
        }

        if (Input.GetKeyDown("space"))
            {
                if (jump < 2 && left <= 1 && right <= 1)
                {
                    rb.AddForce(0, 400, 0);
                    ++jump;
                }
                else if (left == 2)
                {
                    transform.Rotate(0, -90, 0);
                    left = 0;
                    right = 1;
                }
                else if (right == 2)
                {
                    transform.Rotate(0, 90, 0);
                    left = 1;
                    right = 0;
                }
            }
        
    }

   private IEnumerator WaitAfterDead() {

        anim.SetBool("Death", true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameScene");
    }

    
}
 
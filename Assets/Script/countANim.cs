using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countanim : MonoBehaviour
{
    float time=0;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        if (time<6f&&time >=3)
        {
        animator.SetBool("Hello",true);
        //Invoke("DelayMethod", 3.0f);
        }
        else if (time < 9f && time >= 6f)
        {
                animator.SetBool("Hello",false);
        }
        else if (time < 16f && time >= 9f)
        {
            animator.SetBool("Talk", true);
        }
        else if (time<18f&&time >= 16f)
        {
            animator.SetBool("Talk", false);
        }
        else if (time < 21f && time >= 18f)
        {
            animator.SetBool("Good", true);
        }
        else if (time < 24f && time >= 21f)
        {
            animator.SetBool("Good", false);
        }
        else if (time < 27f && time >= 24)
        {
            animator.SetBool("Point", true);
        }
        else if (time < 30f && time >= 27)
        {
            animator.SetBool("Point", false);
            time = 0;
        }
    }


}
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
        else if (time < 15f && time >= 9f)
        {
            animator.SetBool("Talk", true);
        }
        else if (time >= 15f)
        {
            animator.SetBool("Talk", false);
        }

    }


}
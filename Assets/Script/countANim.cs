using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countANim : MonoBehaviour
{
    float time;
    Animator animator;
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time % 3 == 0)
        {
           
            if (i == 1)
            {
                animator.SetBool("Orc", true);
           }
            else if(i==3)
            {
                animator.SetBool("Taking", true);
            }
            else
            {
                animator.SetBool("Idle", true);
            }
            i=i+1;
        }
    }
}

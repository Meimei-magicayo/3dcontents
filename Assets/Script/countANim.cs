using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countanim : MonoBehaviour
{
    float time;
    Animator animator;
    int i = 0;
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
            i++;
            if (i == 1)
            {
                animator.SetBool("orc", true);
            }

            else if (i == 3)
            {
                animator.SetBool("Talk", true);
            }
            else if (i == 5)
            {
                i = 0;
            }
            else
            {
                animator.SetBool("Idle", true);
            }
        }
    }
}
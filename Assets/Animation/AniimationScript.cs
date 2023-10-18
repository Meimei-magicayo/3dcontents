using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniimationScript : MonoBehaviour
{
    public GameObject AnimObj;
    public Animator animator;
          
    // Start is called before the first frame update
    void Start()
    {
        animator = AnimObj.GetComponent<Animator>();  
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButton()
    {
        animator.SetInteger("Transition", 0);   
    }
}

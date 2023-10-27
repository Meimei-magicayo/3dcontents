using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countanim : MonoBehaviour
{
    bool AudioSet;
    float time=0;
    Animator animator;
    AudioSource audioSource;
    public AudioClip sound1, sound2, sound3, sound4;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "M")
        {
        audioSource.volume = 0.5f;
        }
        else if (this.gameObject.tag == "W")
        {
            audioSource.volume = 0.1f;
        }

        this.time += Time.deltaTime;
        if (3.5f > time && time >= 3)
        {
           audioSource.PlayOneShot(sound1);
        }
        if (13.5f > time && time >= 13)
        {
            audioSource.PlayOneShot(sound2);
        }
        if (19.5f > time && time >= 19)
        {
            audioSource.PlayOneShot(sound3);
        }
        if (24.5f > time && time >= 24)
        {
            audioSource.PlayOneShot(sound4);
        }
    
        
        if (time < 10f && time >= 3)
        {



            animator.SetBool("Hello", true);
            
            //Invoke("DelayMethod", 3.0f);
        }
        else if (time < 13f && time >= 10f)
        {
            animator.SetBool("Hello", false);
        }
        else if (time < 16f && time >= 13f)
        {
            //audioSource.PlayOneShot(sound2);
            animator.SetBool("Good", true);
        }
        else if (time < 19f && time >= 16f)
        {
            animator.SetBool("Good", false);
        }
        else if (time < 21f && time >= 19f)
        {
            //audioSource.PlayOneShot(sound3);
            animator.SetBool("Sorry", true);
        }
        else if (time < 24f && time >= 21f)
        {
            animator.SetBool("Sorry", false);
        }
        else if (time < 27f && time >= 24)
        {
            //audioSource.PlayOneShot(sound4);
            animator.SetBool("Bye", true);
        }
        else if (time < 30f && time >= 27)
        {
            animator.SetBool("Bye", false);
            time = 0;
        }
    }

           /* if (gameObject.tag == "Mkeigo")
            {

            }
            else if (gameObject.tag == "Mtame")
            {

            }
            else if (gameObject.tag == "Wkeigo")
            {

            }
            else if(gameObject.tag=="Wtame")
            {

            }*/
}
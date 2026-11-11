using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tela_init : MonoBehaviour
{
    Animator controller_anim;
    [SerializeField] AudioSource notification;
    [SerializeField] Game_Controller controller_game;

    bool play_1;
    bool play_2;
    void Start()
    {
        controller_game.solving_event = true;
        controller_anim = GetComponent<Animator>();
        play_1 = false;
        play_2 = false;
    }

    
    void Update()
    {
        
        if(controller_anim.GetCurrentAnimatorStateInfo(0).IsName("notice_1") && !play_1)
        {
            play_1 = true;
            notification.Play();
        }
        if (controller_anim.GetCurrentAnimatorStateInfo(0).IsName("notice_2") && !play_2)
        {
            play_2 = true;
            notification.Play();
        }

        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("ended"))
        {
            controller_anim.SetTrigger("next");            
            
        }

        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("tutorial"))
        {            
            controller_anim.SetTrigger("next");

        }


        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("tutorial2"))
        {
            controller_anim.SetTrigger("next");

        }


        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("tutorial2"))
        {
            controller_anim.SetTrigger("next");
        }


        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("tutorial3"))
        {
            controller_anim.SetTrigger("next");         

        }


        if (Input.GetMouseButtonDown(0) && controller_anim.GetCurrentAnimatorStateInfo(0).IsName("tutorial4"))
        {
           controller_game.solving_event = false;
            controller_game.really_start();

            
           Destroy(gameObject);

        }

    }
}

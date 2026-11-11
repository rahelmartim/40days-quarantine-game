using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class influence_button : MonoBehaviour
{

    public bool mouse_in;
    [SerializeField] GameObject canvas;
    [SerializeField] Game_Controller controller;
    
    void Start()
    {
        mouse_in = false;   
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && mouse_in)
        {
            canvas.SetActive(true);
            controller.solving_event = true;
            canvas.GetComponent<influence_painel>().update_influences();
        }
    }

    public void closed_clicked()
    {
        canvas.SetActive(false);
        controller.solving_event = false;
    }

    private void OnMouseEnter()
    {
        mouse_in = true;
    }

    private void OnMouseExit()
    {
        mouse_in = false;
    }
}

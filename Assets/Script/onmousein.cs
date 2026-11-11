using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class onmousein : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] AudioSource som;
    private void OnMouseEnter()
    {

    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        som.Play();
        Debug.Log("digdgijhou");
    }
}

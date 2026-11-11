using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerWin : MonoBehaviour
{
    [SerializeField] Text inflences;
    void Start()
    {
        inflences.text = PlayerPrefs.GetString("win_message");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

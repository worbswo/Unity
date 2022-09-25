using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.AddListener(GameManager.EventType.Touch,OnPlayerDetection);
        GameManager.instance.AddListener(GameManager.EventType.Die, OnPlayerDie);
        GameManager.instance.AddListener(GameManager.EventType.EcitTouch, onPlayerExitDetection);
    }
    void OnPlayerDetection(){
        Debug.Log("Red Alert");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    void OnPlayerDie(){
        Debug.Log("Player Dead");
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    void onPlayerExitDetection(){
        Debug.Log("Exit Detection");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

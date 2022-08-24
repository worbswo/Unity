using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    public float speed = 3.0f;
    float rot = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(Vector3.up*-rot*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(Vector3.up*rot*Time.deltaTime);
        }
    }
}

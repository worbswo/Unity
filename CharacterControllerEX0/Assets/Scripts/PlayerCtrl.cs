using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    int speed =3;
    int rotation_speed =2;
    public float gravity = 9.8f;
    void Start()
    {   
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDir.z = Input.GetAxis("Vertical") * speed;
        transform.Rotate(0,Input.GetAxis("Horizontal")* rotation_speed,0);
        if(controller.isGrounded){
            moveDir.y = 0;
        }else{
            moveDir.y -=gravity * Time.deltaTime;
        }
        Vector3 globaDir =transform.TransformDirection(moveDir);
        controller.Move(globaDir*Time.deltaTime);
    }
}

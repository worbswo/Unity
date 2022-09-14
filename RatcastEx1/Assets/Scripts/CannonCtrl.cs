using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour
{
    GameObject turretObj;
    Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        turretObj = GameObject.Find("Turret");
        pos = turretObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(pos.transform.position,pos.transform.forward*12,Color.red);
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward*3*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.forward*-3*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right*3*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left*3*Time.deltaTime);
        }
        RaycastHit hit;
        if(Input.GetKey(KeyCode.Space)){
            if(Physics.Raycast(pos.transform.position,pos.transform.forward,out hit, 12.0f)){
                Debug.Log(hit.collider.gameObject.name);
                Debug.Log(hit.distance);
            }else{
                Debug.Log("Nothing");
            }
        }
    }
}

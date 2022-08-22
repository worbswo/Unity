using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float speed =3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpaceShipMove();
    }
    void SpaceShipMove(){
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector2.up*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector2.down*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left*speed*Time.deltaTime);
        }
    }
}

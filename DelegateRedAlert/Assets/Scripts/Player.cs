using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void PlayerEventHandler();

    int health = 50;
    public float speed =3f;
    GameObject[] enemyObj;
    public int Health{
        get{return health;}
        set{
            health = Mathf.Clamp(value,0,100);
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        enemyObj = GameObject.FindGameObjectsWithTag("ENEMY");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Health = Health-5;
        }
        PlayerMove();

        if(Health<=0){
            foreach(GameObject obj in enemyObj){
                obj.SendMessage("OnPlayerDie",SendMessageOptions.DontRequireReceiver);
            }
        }
    }
    void PlayerMove(){
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("CHECKPOINT")){
            foreach(GameObject obj in enemyObj){
                obj.SendMessage("OnPlayerDetection",SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    void OnTriggerExit(Collider other){
        if(other.CompareTag("CHECKPOINT")){
            foreach(GameObject obj in enemyObj){
                obj.SendMessage("onPlayerExitDetection",SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform randPos;
    public GameObject fightingCar;
    int numOfCar = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numOfCar;i++){
            randPos.position = new Vector3(Random.Range(-7f,7f),0,Random.Range(28f,32f));
            Instantiate(fightingCar,randPos.position,randPos.rotation);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

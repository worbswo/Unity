using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Scene을 전환하기 위해 필요
using UnityEngine.SceneManagement;
//버튼 UI를 처리하기위해 필요
using UnityEngine.EventSystems;
public class TitleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void onButtonClick(){
        // GameScene 씬을 불러온다
        SceneManager.LoadScene("GameScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

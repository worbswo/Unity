using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCtrl : MonoBehaviour
{
    protected Animator mAvatar;
    // Start is called before the first frame update
    void Start()
    {
        mAvatar = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OnAttackBtn(){
        mAvatar.SetTrigger("ATTACK");

    }
    void Update()
    {
    }
}

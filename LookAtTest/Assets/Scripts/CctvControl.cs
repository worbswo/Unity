using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CctvControl : MonoBehaviour
{
    // Start is called before the first frame update
    Transform pos = null;
    void Start()
    {
        pos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(pos);
    }
}

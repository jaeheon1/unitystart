using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
   [SerializeField]int time=3;
   MeshRenderer renderer;
   Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled=false;
        rigid.useGravity = false;
    }

    void Update()
    {
        if(Time.time>time)
        {
            renderer.enabled = true;
            rigid.useGravity = true;
        }
    }
}

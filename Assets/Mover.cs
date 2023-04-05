using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]  float yValue = 0.01f;
    [SerializeField] float zValue = 0f;
   
    void Start()
    {
       
    }

   
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0, yValue);
    }
}

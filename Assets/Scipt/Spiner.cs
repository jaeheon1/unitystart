using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] float xValue = 1f;
    [SerializeField] float yValue = 1f;
    [SerializeField] float zValue = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}

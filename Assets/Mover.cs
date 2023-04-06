using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]  float yValue = 0.01f;
    [SerializeField] float zValue = 0f;
    [SerializeField] float speed = 10f;
    void Start()
    {
        PrintInstruction();
    }

   
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("게임에 오신걸 환영합니다");
        Debug.Log("안녕하세요");
        Debug.Log("저는 정재헌이라고 하는 사람입니다  ");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, yValue);
    }
}

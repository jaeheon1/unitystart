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
        Debug.Log("���ӿ� ���Ű� ȯ���մϴ�");
        Debug.Log("�ȳ��ϼ���");
        Debug.Log("���� �������̶�� �ϴ� ����Դϴ�  ");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, yValue);
    }
}

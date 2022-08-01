using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{

    Rigidbody rigid;
    ParticleSystem effect;
   
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        effect = GetComponentInChildren<ParticleSystem>();
    }


    private void OnMouseDown()
    {
        effect.Play();
    }



    private void OnMouseDrag()
    {
        rigid.isKinematic = true;

        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.WorldToScreenPoint(gameObject.transform.position).z);

        //���콺 ��ǥ�� ScreenToWorldPoint �� 
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

    }


    private void OnMouseUp()
    {
        rigid.isKinematic = false;       
    }
}

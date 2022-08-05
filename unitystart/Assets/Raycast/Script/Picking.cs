using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{

    public LayerMask layer;
    private RaycastHit hit;
    
    void Update()
    {
        //GetmouseButton (0) ���콺 ���� ��ư�� Ŭ�� ������ 
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //������ �߻��� ���� ������ �浹�� ���� ������Ʈ�� �ִٸ� hit ������ �����͸� �����մϴ�. 


            if(Physics.Raycast(ray,out hit,layer)) //layer�� �ش� layer�� �����Ͽ� �浹�մϴ�.
            {

                hit.collider.gameObject.GetComponent<Renderer>().material = Resources.Load<Material>("Ice");

            }
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    
    void Start()
    {
        int value = 10;
        int variable = 20;

        value = variable;


        Item sword = new Item();

        Item hat = new Item();
        hat = sword;

        hat.Information(1000, 10);
        sword.Information(5000, 10);

        Debug.Log("hat����:" + hat.price + "hatũ��:" + hat.size);
        Debug.Log("sword����:" + sword.price + "swordũ��:" + sword.size);

    }


    void Update()
    {
        
    }
}


public class Item
{
     public int price;
     public int size;

    public void Information(int price,int size)
    {
        this.price = price;
        this.size = size;

        
    }
}

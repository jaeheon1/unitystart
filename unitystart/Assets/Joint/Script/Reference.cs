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

        Debug.Log("hat가격:" + hat.price + "hat크기:" + hat.size);
        Debug.Log("sword가격:" + sword.price + "sword크기:" + sword.size);

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
  void OnCollisionEnter(Collision other)
    {
       
        if(other.gameObject.tag!="Hit")
        {
            score++;
            print("´ç½ÅÀº" + score + "ºÎµú");
        }
    }
}

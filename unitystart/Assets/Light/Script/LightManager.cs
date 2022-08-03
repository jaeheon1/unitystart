using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

   public  bool state = false;
    [SerializeField] GameObject[] lightEffect;
 

    public void LightSetting(int number)
    {
        state = !state;
        lightEffect[number].SetActive(state);

    }


}

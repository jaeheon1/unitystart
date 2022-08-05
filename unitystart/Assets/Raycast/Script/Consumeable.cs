using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Consumeable : MonoBehaviour
{

    [SerializeField] Image boader;
    [SerializeField] Item1 item;
    [SerializeField] Image picture;
    [SerializeField] Image purchasePicture;
    [SerializeField] Text price;

    
    void Start()
    {
        boader.sprite = item.outline;
        picture.sprite = item.Picture;
        purchasePicture.sprite = item.purchasePicture;
        price.text = item.price.ToString();
    }

    
    
}

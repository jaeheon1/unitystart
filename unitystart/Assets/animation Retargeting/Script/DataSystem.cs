using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSystem : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("speed", speed);
    }
    public void Load()
    {
        speed = PlayerPrefs.GetFloat("speed");
    }
}

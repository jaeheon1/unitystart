using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int money;
    public int hat;
    public int stick;

    private void Awake()
    {
        //���� ���� ���Ŀ� ������ �ȵǱ� ������ Awake()�Լ����� NULLüũ�� �մϴ�. 
        if(instance==null)
        {
            //this �� static �� �����ؾ� ������ ����� �� �ֽ��ϴ�. 
            instance = this;
        }

        LoadData();



    }




    public void SaveData()
    {

        //����Ƽ ���ο� key("") value() �� �����մϴ�. 
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("hat", hat);
        PlayerPrefs.SetInt("stick", stick);



    }

    public void LoadData()
    {

        //����Ƽ ���ο� ����Ǿ� �ִ� key ("") ���� �ҷ��ɴϴ�.
        money = PlayerPrefs.GetInt("money");

        hat = PlayerPrefs.GetInt("hat");

        stick = PlayerPrefs.GetInt("stick");
    }

    public void IncreaseMoney()
    {
        money += 100;
        SaveData();


    }


}

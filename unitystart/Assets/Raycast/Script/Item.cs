using UnityEngine;



[CreateAssetMenu(fileName = "Item1", menuName = "Scriptable Object/Item1", order = 0)]
public class Item1 : ScriptableObject
{
    public int price;
    public string name;
    public Sprite picture;
    public Sprite outline;
}
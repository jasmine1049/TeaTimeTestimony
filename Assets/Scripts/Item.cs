using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "TeaTimeTestimony/Item", order = 1)]
public class Item : ScriptableObject {
    public string name;
    public string description;
    public Sprite image;
}

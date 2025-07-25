using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "Scriptble Object/ItemData")]

public class ItemData : ScriptableObject
{
    public enum ItemType { Shovel, Pistol, Glove, Shoe, Heal, Fork, Shotgun, Sickle, MachineGun }

    [Header("# Main Info")]
    public ItemType itemType;
    public int itemId;
    public string itemName;
    [TextArea]
    public string itemDesc;
    //public string itemDmg;
    public Sprite itemIcon;

    [Header("# Level Data")]
    public float baseDamage;
    public int baseCount;
    public float[] damages;
    public int[] counts;


    [Header("# Weapon")]
    public GameObject projectile;
    public Sprite hand;
}

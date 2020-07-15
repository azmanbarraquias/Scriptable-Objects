using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/Manual/class-ScriptableObject.html

/* A ScriptableObject is a data container that you can use to save large amounts of data, 
 * independent of class instances. One of the main use cases for ScriptableObjects is 
 * to reduce your Project’s memory usage by avoiding copies of values. 
 * This is useful if your Project has a Prefab 
 * that stores unchanging data in attached MonoBehaviour scripts */

// [CreateAssetMenu(fileName ="New Card", menuName = "Card/Minions")] // Submenu
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    //public string name;
    public new string name; // new name to differentiate

    [TextArea(3, 10)]
    public string description;

    public Sprite artwork;

    public int manaCost;
    public int attack;
    public int health;
}

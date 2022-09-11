using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   public enum ItemType{
       
       none,
       mainDish,
       dessert,
       soup,
       meat,
       dough,
       vegetable
   }
   public ItemScriptableObject itemScriptableObject;
}

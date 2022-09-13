using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubPots 
{
    ItemScriptableObject CreateMeal();
    void Creation();
    void RemoveFromPot(int meatCount,int vegeCount,int doughCount);
}

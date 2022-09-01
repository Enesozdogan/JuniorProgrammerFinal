using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;
    [SerializeField] TextMeshProUGUI meatCount,vegetableCount,doughCount;
     
    public List<GameObject> meatList;
    public List<GameObject> vegetableList;
    public List<GameObject> doughList;

    private void Start() {
        if(DataManager.Instance!=null) playerName.text=DataManager.Instance.userName;
         meatCount.text="Meat: "+meatList.Count;
         vegetableCount.text="Vegetable: "+vegetableList.Count;
         doughCount.text="Dough: "+doughList.Count;
        Debug.Log( "meat: "+ meatList.Count+ " vege: " +vegetableList.Count + " dough: "+ doughList.Count);
    }

    public void AddToMeat(GameObject meat){
        meatList.Add(meat);
        meatCount.text="Meat: "+meatList.Count;
    }
    public void AddToVegetable(GameObject vegetable){
        vegetableList.Add(vegetable);
        vegetableCount.text="Vegetable: "+vegetableList.Count+1;
    }
    public void AddToDough(GameObject dough){
        doughList.Add(dough);
        doughCount.text="Dough: "+doughList.Count+1;
    }
}

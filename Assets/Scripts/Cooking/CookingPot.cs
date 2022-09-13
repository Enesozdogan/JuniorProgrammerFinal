using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class CookingPot : MonoBehaviour,IDropHandler
{
    public MainManager mainManager;
    public TextMeshProUGUI meatPotCount,vegePotCount,doughPotCount;
    
    public List<GameObject> meat_PotList;
    public List<GameObject> vege_PotList;
    public List<GameObject> dough_PotList;
   
     public void AddToMeat(GameObject meat){
        meat_PotList.Add(meat);
        meatPotCount.text="Meat: "+meat_PotList.Count;
        
    }
    public void AddToVege(GameObject vegetable){
        vege_PotList.Add(vegetable);
        vegePotCount.text="Vegetable: "+vege_PotList.Count;
        
    }
      public void AddToDough(GameObject dough){
        dough_PotList.Add(dough);
        doughPotCount.text="Dough: "+dough_PotList.Count;
        
    }
    public void OnDrop(PointerEventData eventData)
    {
       Debug.Log("Dropped in to : "+gameObject.name );
       if(eventData.pointerDrag!=null){
           eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
           if(eventData.pointerDrag.gameObject.CompareTag("Meat")){
                AddToMeat(eventData.pointerDrag.gameObject);
                //Destroy(eventData.pointerDrag.gameObject);
                eventData.pointerDrag.gameObject.SetActive(false);
                mainManager.SubToMeat(1);  
                mainManager.CreateMeat();
           }
           else if(eventData.pointerDrag.gameObject.CompareTag("Vegetable")){
               AddToVege(eventData.pointerDrag.gameObject);
               eventData.pointerDrag.gameObject.SetActive(false);
               mainManager.SubToVegetable(1);
               mainManager.CreateVegetable();
           }
           else if(eventData.pointerDrag.gameObject.CompareTag("Dough")){
               AddToDough(eventData.pointerDrag.gameObject);
               eventData.pointerDrag.gameObject.SetActive(false);
               mainManager.SubToDough(1);
               mainManager.CreateDough();
           }
       }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class CookingPot : MonoBehaviour,IDropHandler
{
    public MainManager mainManager;
    [SerializeField] TextMeshProUGUI meatPotCount,vegePotCount,doughPotCount;
    
    public List<GameObject> meat_PotList;
    public List<GameObject> vege_PotList;
    public List<GameObject> dough_PotList;
     public void AddToMeat(GameObject meat){
        meat_PotList.Add(meat);
        meatPotCount.text="Meat: "+meat_PotList.Count;
        
    }
    public void OnDrop(PointerEventData eventData)
    {
       Debug.Log("Dropped in to : "+gameObject.name );
       if(eventData.pointerDrag!=null){
           eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
           if(eventData.pointerDrag.gameObject.CompareTag("Meat")){
                AddToMeat(eventData.pointerDrag.gameObject);
                Destroy(eventData.pointerDrag.gameObject);
                mainManager.SubToMeat(1);  
                mainManager.CreateMeat();
           }
           else if(eventData.pointerDrag.gameObject.CompareTag("Vegetable")){

               Destroy(eventData.pointerDrag.gameObject,0.2f);
              
           }
       }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CookingPot : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
       Debug.Log("Dropped in to : "+gameObject.name );
       if(eventData.pointerDrag!=null){
           eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
           if(eventData.pointerDrag.gameObject.CompareTag("Food")){
               Destroy(eventData.pointerDrag.gameObject,0.2f);
           }
       }
    }

    
}

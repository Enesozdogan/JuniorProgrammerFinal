using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;
    [SerializeField] TextMeshProUGUI meatCountText,vegetableCountText,doughCountText;
    public GameObject[] primitiveIng;

    public Sprite meat;
    public int meatCount;
    public Canvas canvas;
    public int vegetableCount;
    public int  doughCount;

    private void Start() {
        
        if(DataManager.Instance!=null) playerName.text=DataManager.Instance.userName;
         meatCountText.text="Meat: "+meatCount;
         vegetableCountText.text="Vegetable: "+vegetableCount;
         doughCountText.text="Dough: "+doughCount;
        Debug.Log( "meat: "+ meatCount+ " vege: " +vegetableCount + " dough: "+ doughCount);
    }

    public void AddToMeat(int x){
        meatCount+=x;
        meatCountText.text="Meat: "+meatCount;
    }
    public void AddToVegetable(int  x){
        vegetableCount+=x;
        vegetableCountText.text="Vegetable: "+vegetableCount;
    }
    public void AddToDough(int x){
        doughCount+=x;
        meatCountText.text="Dough: "+doughCount;
    }
      public void SubToMeat(int x){
        meatCount-=x;
        meatCountText.text="Meat: "+meatCount;
    }
    public void SubToVegetable(int  x){
        vegetableCount-=x;
        vegetableCountText.text="Vegetable: "+vegetableCount;
    }
    public void SubToDough(int x){
        doughCount-=x;
        meatCountText.text="Dough: "+doughCount;
    }
    public void CreateMeat(){
        if(meatCount>0){
            
            var obj=Instantiate(primitiveIng[0]);
            obj.transform.SetParent(canvas.transform);
            obj.AddComponent<DragDrop>();
            obj.transform.localPosition=obj.GetComponentInParent<RectTransform>().position;
            obj.transform.localScale=Vector3.one;
        }
    }
    public void CreateVegetable(){
        if(vegetableCount>0){
            var obj=Instantiate(primitiveIng[1]);
            obj.transform.SetParent(canvas.transform);
            obj.AddComponent<DragDrop>();
            obj.transform.localPosition=obj.GetComponentInParent<RectTransform>().position;
            obj.transform.localScale=Vector3.one;
        }

    }
    public void CreateDough(){
        if(doughCount>0){
            var obj=Instantiate(primitiveIng[2]);
            obj.transform.SetParent(canvas.transform);
            obj.AddComponent<DragDrop>();
            obj.transform.localPosition=obj.GetComponentInParent<RectTransform>().position;
            obj.transform.localScale=Vector3.one;
        }
    }
}

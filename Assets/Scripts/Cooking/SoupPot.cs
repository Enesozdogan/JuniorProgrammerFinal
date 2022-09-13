using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupPot :CookingPot ,ISubPots
{
 int meatpara,vegepara,doughpara;
    bool complete=true;
    public GameObject xd;
    private Item outputItem;
    bool waterAdded=false;
    public List<CraftingRecipe> craftingRecipes;
    public  ItemScriptableObject CreateMeal(){
        foreach(CraftingRecipe craftingRecipe in craftingRecipes){
            complete=true;
            if(meat_PotList.Count!=craftingRecipe.meatAmount)complete=false;        
            if(vege_PotList.Count!=craftingRecipe.vegeAmount)complete=false;
            if(dough_PotList.Count!=craftingRecipe.doughAmount)complete=false;
            if(!waterAdded) complete=false;
            if(complete){
                Debug.Log("Meal created :"+ craftingRecipe.output.name);
                meatpara=craftingRecipe.meatAmount; vegepara=craftingRecipe.vegeAmount; doughpara=craftingRecipe.doughAmount;
                CreateMealObject(craftingRecipe);
                return craftingRecipe.output;
                
            }

        }
        return null;

    }
    public void AddWater(){
        waterAdded=true;
    }
    void CreateMealObject(CraftingRecipe craftingRecipe){
                GameObject za=Instantiate(xd,new Vector3(0,1.79999995f,-1242.09998f),Quaternion.identity);
                za.transform.localScale=new Vector3(1,1,0.352420002f);
                za.AddComponent<Item>();
                za.AddComponent<SpriteRenderer>();
                za.GetComponent<Item>().itemScriptableObject=craftingRecipe.output;
                za.GetComponent<SpriteRenderer>().sprite=craftingRecipe.output.itemSprite;
    }

    public void Creation()
    {
        ItemScriptableObject recipeOutput=CreateMeal();
        if(recipeOutput==null)Debug.Log("No recipe avaiable");
        RemoveFromPot(meatpara,vegepara,doughpara);
    }

    public void RemoveFromPot(int meatCount, int vegeCount, int doughCount)
    {
        if(meatCount>0) StartCoroutine(RemoveMeat(meatCount)); 
        if(vegeCount>0) StartCoroutine(RemoveVege(vegeCount));
        if(doughCount>0) StartCoroutine(RemoveDough(doughCount));
       
        meatPotCount.text="Meat: "+meat_PotList.Count;
        doughPotCount.text="Dough: "+dough_PotList.Count;
        vegePotCount.text="Vegetable: "+vege_PotList.Count;
    }
    IEnumerator RemoveVege(int vegeCount){
        int i=0,count=0;
        while(i<vege_PotList.Count && count<vegeCount ){
            if(vege_PotList[i].CompareTag("Vegetable")){
                vege_PotList.RemoveAt(i);
                count++;
            }
        }
        yield return null;
    }
     IEnumerator RemoveMeat(int meatCount){
        int i=0,count=0;
        while(i<meat_PotList.Count && count<meatCount ){
            if(meat_PotList[i].CompareTag("Meat")){
                meat_PotList.RemoveAt(i);
                count++;
            }
        }
        yield return null;
    }
     IEnumerator RemoveDough(int doughCount){
        int i=0,count=0;
        while(i<dough_PotList.Count && count<doughCount ){
            if(dough_PotList[i].CompareTag("Dough")){
                dough_PotList.RemoveAt(i);
                count++;
            }
        }
        yield return null;
    }
    
}

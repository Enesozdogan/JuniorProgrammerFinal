using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MainMenuPot : CookingPot
{
    bool complete=true;
    public GameObject xd;
    private Item outputItem;
    public List<CraftingRecipe> craftingRecipes;
    public ItemScriptableObject CreateMeal(){
        foreach(CraftingRecipe craftingRecipe in craftingRecipes){
            complete=true;
            if(meat_PotList.Count<craftingRecipe.meatAmount){
                complete=false;    
            }
            if(vege_PotList.Count<craftingRecipe.vegeAmount){
                complete=false;
            }
            if(dough_PotList.Count<craftingRecipe.doughAmount){
                complete=false;
            }
            if(complete){
                Debug.Log("Meal created :"+ craftingRecipe.output.name);
                GameObject za=Instantiate(xd,new Vector3(0,1.79999995f,-1242.09998f),Quaternion.identity);
                //za.transform.localScale=new Vector3(0.00865101721f,0.026690105f,0.352420002f);
                za.AddComponent<Item>();
                za.AddComponent<SpriteRenderer>();
                za.GetComponent<Item>().itemScriptableObject=craftingRecipe.output;
                za.GetComponent<SpriteRenderer>().sprite=craftingRecipe.output.itemSprite;
                return craftingRecipe.output;
                
            }

        }
        return null;

    }
    public void Creation(){
        ItemScriptableObject recipeOutput=CreateMeal();
        
      
    }
    public Item GetOutputItem(){
        return outputItem;
    }
}

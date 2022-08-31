using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    
    public void DebugUserName(){
        Debug.Log("your user name is:" + nameInput.text);
    }
    public void SendName(){
        DataManager.Instance.userName=nameInput.text;
    }
    public void Startgame(){
        SceneManager.LoadScene(1);
    }


}

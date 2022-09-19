using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject tutorialPanel;
    public void OpenTutorialPanel(){
        tutorialPanel.SetActive(true);
    }
    public void CloseTutorialPanel(){
         tutorialPanel.SetActive(false);
    }
}


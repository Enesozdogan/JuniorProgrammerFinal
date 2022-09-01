using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerName;

    private void Start() {
        playerName.text=DataManager.Instance.userName;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    [SerializeField] Text titleText;
    public void OnEnter()
    {
        titleText.fontSize = 80;
        Debug.Log("Enter");
    }
    public void OnDown()
    {
        titleText.fontSize = 50;
        Debug.Log("Down");
    }
    public void OnExit()
    {
        titleText.fontSize = 65;
        Debug.Log("Exit");
    }
}

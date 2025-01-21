using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    [SerializeField] Text[] textList;
    [SerializeField] string[] titleList;

    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }
    public void SetText()
    {
        for(int i = 0; i < textList.Length; i++)
        {
            textList[i].text = titleList[i];
        }
    }
    
    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Shop()
    {
        Debug.Log("Shop");
    }

    public void Quit()
    {
        Debug.Log("Quit");
    }
}

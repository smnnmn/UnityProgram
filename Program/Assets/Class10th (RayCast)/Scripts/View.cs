using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] bool power = false;
    public void Show()
    {
        transform.GetChild(0).gameObject.SetActive(!power);
        power = !power;
        
    }
}

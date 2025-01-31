using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    [SerializeField] string title;
    [SerializeField] string description;

    private Text titleText;
    private Text descriptionText;
    // Start is called before the first frame update
    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<Text>();
        descriptionText = transform.GetChild(1).GetComponent<Text>();
    }
    void Start()
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}

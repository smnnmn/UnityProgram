using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraith : MonoBehaviour
{
    [SerializeField] int minTime = 1;
    [SerializeField] int maxTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Random.Range(minTime, maxTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    private Ray ray;
    private RaycastHit rayCastHit;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity,layerMask))
            {
                rayCastHit.transform.GetComponent<View>().Show();
            }
        }

    }
}

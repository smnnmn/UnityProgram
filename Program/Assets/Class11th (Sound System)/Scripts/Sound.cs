using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    [SerializeField] int seed = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Coroutine());
    }
    IEnumerator Coroutine()
    {
        while (true)
        {
            seed = Random.Range(1, 6);

            yield return new WaitForSeconds(seed);

            Debug.Log("Coroutine");
        }
    }
}

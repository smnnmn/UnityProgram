using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBall : MonoBehaviour, IDamageable
{
    public void Use()
    {
        Debug.Log("이 공은 배구공이다.");
    }
}

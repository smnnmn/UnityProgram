using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour, IDamageable
{
    public void Use()
    {
        Debug.Log("이 공은 축구공이다.");
    }
}

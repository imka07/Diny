using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    [SerializeField] private float lifeTime = 11;
    void Start()
    {
        Destroy(gameObject, 11);
    }

}

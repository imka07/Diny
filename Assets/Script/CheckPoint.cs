using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    public Vector3 playerSpawnPosition { get => spawnPoint.position; }
    //public Vector3 worldPosition { get => transform.parent.parent.position; }
}


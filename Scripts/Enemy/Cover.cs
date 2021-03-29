using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cover : MonoBehaviour
{
    [SerializeField] private Transform[] coverSpots;

    public Transform[] GetCoverSpots()
    {
        Debug.Log("Cover.cs");
        return coverSpots;
    }

}

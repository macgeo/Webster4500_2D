using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawnerMWB : MonoBehaviour
{
    public GameObject cratePrefab;

    public int amountOfCratesToSpawn;

    private void Start()
    {
        for (int i = 0; i < amountOfCratesToSpawn; i++)
        {
            Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
        }
    }
}

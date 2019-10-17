using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject cratePrefab;

    [Range(0,100)]
    public int amountOfCratesToCreate;

    void Start()
    {
        //for (int i = 0; i < amountOfCratesToCreate; i++)
        //{
        //    Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
        //}

        int i = 0;
        while (i < amountOfCratesToCreate)
        {
            Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
            i++;
        }
    }
}

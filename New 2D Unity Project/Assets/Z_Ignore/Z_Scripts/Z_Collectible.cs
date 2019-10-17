using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollected();
    }

    void HandleCollected()
    {
        Destroy(gameObject);
        Z_CollectibleManager.Instance.HandleCoinCollected();
    }
}

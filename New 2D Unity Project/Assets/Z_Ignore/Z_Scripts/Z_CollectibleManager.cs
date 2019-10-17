using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Z_CollectibleManager : MonoBehaviour
{
    public static Z_CollectibleManager Instance;

    public TextMeshProUGUI coinCount;

    private int _totalCoins;
    private int _collectedCoins;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _totalCoins = FindObjectsOfType<Collectible>().Length;
        DisplayCoinCount();
    }

    void DisplayCoinCount()
    {
        coinCount.SetText(_collectedCoins + " / " + _totalCoins);
    }

    public void HandleCoinCollected()
    {
        _collectedCoins++;
        DisplayCoinCount();
    }
}

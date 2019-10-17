using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalCoins;
    private int _collectedCoins;

    public TextMeshProUGUI coinCount;

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

        if (_collectedCoins >= _totalCoins)
        {
            YouWinMenu.Instance.Show();
            SoundManager.Instance.PlayWinSound();

        }
        else
        {

            SoundManager.Instance.PlayCoinCollectSound();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            SoundManager.Instance.PlayDeathSound();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

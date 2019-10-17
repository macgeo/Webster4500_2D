using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityEngine.SceneManagement;

public class Z_Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }

        //Destroy(collision.gameObject);
    }
}

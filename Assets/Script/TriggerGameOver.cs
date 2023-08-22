using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (col == bola)
        {
            gameOverCanvas.SetActive(true);
        }
    }

}

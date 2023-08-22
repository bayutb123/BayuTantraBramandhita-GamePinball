using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}

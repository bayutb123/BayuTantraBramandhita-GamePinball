using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        score += addition;
        Debug.Log("Current Score : " + score);
    }

    // Update is called once per frame
    public void ResetScore()
    {
        score = 0;
    }
}

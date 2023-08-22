using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScoreCollider : MonoBehaviour
{
    public Collider bola;
    [SerializeField]
    private float scoreCount;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    private void OnTriggerExit(Collider col)
    {
        if (col == bola)
        {
            scoreManager.AddScore(scoreCount);
        }
    }
}

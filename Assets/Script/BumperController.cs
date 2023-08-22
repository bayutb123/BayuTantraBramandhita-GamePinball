using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField]
    private float scoreCount;
    
    public Collider bola;
    
    public float multiplier;
    public Color color;
    private Renderer renderer;
    private Animator animator;
    public VFXManager vfxManager;
    public AudioManager audioManager;
    public ScoreManager scoreManager;
    // Start is called before the first frame update

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.collider == bola) {
            Rigidbody rig = bola.GetComponent<Rigidbody>();
            rig.velocity *= multiplier;
            animator.SetTrigger("Ball Hit Bumper");
            audioManager.PlaySFX(col.transform.position);
            vfxManager.PlayVFX(col.transform.position);
            scoreManager.AddScore(scoreCount);
        }
    }
}

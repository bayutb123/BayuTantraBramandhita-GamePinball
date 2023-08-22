using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

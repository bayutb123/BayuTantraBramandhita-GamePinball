using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{ 
    public Collider bola;
    public CameraController cameraController;
    public float length;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider col)
    {
        cameraController.FocusAtTarget(bola.transform, length);
    }
    
}

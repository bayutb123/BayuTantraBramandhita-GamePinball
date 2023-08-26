using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public KeyCode key;
    public Collider bola;

    // untuk set berapa lama waktu yang harus dicapai hingga maksimal force
    public float maxTimeHold;
    // untuk set berapa besar maksimal force yang bisa didapat (ini menggantikan force)
    public float maxForce;
    // state pada launcher
    private bool isHold;

    void Start()
    {
        isHold = false;
    }
    // Start is called before the first frame update
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    // Update is called once per frame
    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(key) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;
        float timeHold = 0f;
        float force = 0f;
        while (Input.GetKey(key)) 
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}

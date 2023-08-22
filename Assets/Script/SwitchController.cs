using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        On,
        Off,
        Blink
    }
    [SerializeField]
    private float scoreCount;
    public Collider bola;
    public Material materialOn;
    public Material materialOff;
    private SwitchState switchState;
    private Renderer renderer;
    public ScoreManager scoreManager;

    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider == bola)
        {
            Toggle();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(BlinkTimerStart(5));
        Set(false);
        renderer.material = materialOff;
    }

    private void Set(bool active)
    {
        if (!active)
        {
            switchState = SwitchState.On;
            renderer.material = materialOff;
            StartCoroutine(BlinkTimerStart(5));
        }
        else
        {
            switchState = SwitchState.Off;
            renderer.material = materialOn;
            StopAllCoroutines();

        }
    }



    private IEnumerator Blink(int times)
    {
        switchState = SwitchState.Blink;
        for (int i = 0; i < times; i++)
        {
            renderer.material = materialOn;
            yield return new WaitForSeconds(0.5f);
            renderer.material = materialOff;
            yield return new WaitForSeconds(0.5f);
        }

        switchState = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private void Toggle()
    {
        if (switchState == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
        scoreManager.AddScore(scoreCount);

    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }

}

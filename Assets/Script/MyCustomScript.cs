using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomScript : MonoBehaviour
{
    
    [SerializeField]
    public KeyCode userInput;

    private float targetPressed;
    private float targetRelease;
    private HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        // mengambil spring dari component Hinge joint
        JointSpring jointSpring = hinge.spring;

        // mengubah value spring saat input ditekan dan dilepas
        if (Input.GetKey(userInput))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        // mengubah spring pada Hinge Joint dengan value yang sudah di ubah
        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {

    }
}


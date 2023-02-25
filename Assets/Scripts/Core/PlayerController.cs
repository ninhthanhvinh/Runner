using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    Vector3 XMove;
    public float moveSpeed;

    //private int desiredLane = 1;
    public float laneDistance = 5;

    [SerializeField] private FixedJoystick _joystick;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        direction = transform.forward * moveSpeed;
        XMove = _joystick.Horizontal * moveSpeed * transform.right;
        //if (SwipeController.swipeLeft)
        //{
        //    desiredLane--;
        //    if (desiredLane == -1)
        //        desiredLane = 0;
        //}
        //if (SwipeController.swipeRight)
        //{
        //    desiredLane++;
        //    if (desiredLane == 3)
        //        desiredLane = 2;
        //}

        //Debug.Log(desiredLane);
        //Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        //if (desiredLane == 0)
        //{
        //    targetPosition += Vector3.left * laneDistance;
        //}
        //else if (desiredLane == 2)
        //{
        //    targetPosition += Vector3.right * laneDistance;
        //}

        //transform.position = targetPosition;



    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
        controller.Move(XMove * Time.fixedDeltaTime);
    }

    public void ResetSpeed()
    {
        Invoke(nameof(SetSpeed), 1f);
    }

    void SetSpeed()
    {
        this.moveSpeed = 2;
    }
}

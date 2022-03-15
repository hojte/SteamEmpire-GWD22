using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField] bool hideCursor = true;

    [Header("Scriptable Objects")]
    [SerializeField] CustomInput customInput;

    [Header("Movement")]
    [SerializeField] float walkSpeed = 5;
    [SerializeField] float sprintSpeed = 8;
    [SerializeField] float notForwardMultiplier = 0.75f;
    float currentMoveSpeed = 0;

    [Header("Jump and Falling")]
    [SerializeField] float jumpForce = 10;
    [SerializeField] float jumpDamping = 30;
    [SerializeField] float fallSpeed = 20;
    float currentVertSpeed = 0;

    [Header("Head bobbing")]
    [SerializeField] Transform bobFollowTarget;
    [SerializeField] float walkBobHeight = 0.5f;
    [SerializeField] float walkBobSpeed = 5;
    [SerializeField] float sprintBobHeight = 0.25f;
    [SerializeField] float sprintBobSpeed = 8;
    [SerializeField] float bobResetSpeed = 5;
    float currentBobSpeed = 0;
    float targetBobHeight = 0;
    float startBobHeight;

    CharacterController controller;
    Camera camera;
    CinemachineVirtualCamera cineMachine;

    void Awake()
    {
        if (hideCursor)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        startBobHeight = bobFollowTarget.localPosition.y;

        controller = GetComponent<CharacterController>();
        camera = Camera.main;
        cineMachine = FindObjectOfType<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (customInput.controllerLocked || DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        //Jumping and vertical speed
        if (customInput.isJumping && controller.isGrounded)
            currentVertSpeed = jumpForce;
        else
            currentVertSpeed = Mathf.MoveTowards(currentVertSpeed, -fallSpeed, Time.deltaTime * jumpDamping);

        //Movement speed
        currentMoveSpeed = customInput.isSprinting ? sprintSpeed : walkSpeed;

        //Set rotation
        transform.rotation = Quaternion.Euler(0, camera.transform.rotation.eulerAngles.y, 0);

        Move();
        HeadBobbing();
    }

    void Move()
    {
        //Making sure that if you walk sideways or backwards, you will walks slower than if you walk forwards
        Vector3 _inpDir = customInput.moveDirection;
        if (_inpDir.z < 0) 
            _inpDir.z *= notForwardMultiplier;
        _inpDir.x *= notForwardMultiplier;

        //Sets the correct horizontal and vertical speed
        Vector3 _moveVec = transform.TransformDirection(_inpDir) * currentMoveSpeed;
        _moveVec.y = currentVertSpeed;

        //Moves the player
        controller.Move(_moveVec * Time.deltaTime);
    }

    void HeadBobbing()
    {
        if (customInput.isMoving)
        {
            //Sets the speed and target height of the bobbing
            currentBobSpeed = customInput.isSprinting ? sprintBobSpeed : walkBobSpeed;
            targetBobHeight = customInput.isSprinting ? sprintBobHeight : walkBobHeight;

            float _currentHeight = Mathf.Sin(Time.time * currentBobSpeed) * targetBobHeight * 0.1f;

            //Sets the targets location to correctly
            bobFollowTarget.localPosition = new Vector3(0, startBobHeight + _currentHeight, 0);
        }
        else
        {
            //Resets the target to the bobbing start position
            bobFollowTarget.localPosition = Vector3.MoveTowards(bobFollowTarget.localPosition, new Vector3(0, startBobHeight, 0), Time.deltaTime * bobResetSpeed);
        }
    }
}

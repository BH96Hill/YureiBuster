using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset playerActions; // Inspector�Őݒ肵�܂��B
    public float speed = 1.0f; // �ړ����x�̃p�����[�^�BInspector���璲���\�B

    private InputAction moveAction;

    private void Awake()
    {
        moveAction = playerActions.FindActionMap("Player").FindAction("Move");
    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    private void Update()
    {
        Vector2 inputVec = moveAction.ReadValue<Vector2>();
        Vector3 moveVec = new Vector3(inputVec.x, 0, inputVec.y) * speed * Time.deltaTime;

        transform.position += moveVec;
    }
}

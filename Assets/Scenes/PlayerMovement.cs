using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset playerActions; // Inspectorで設定します。
    public float speed = 1.0f; // 移動速度のパラメータ。Inspectorから調整可能。

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

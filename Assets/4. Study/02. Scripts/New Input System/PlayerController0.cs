using UnityEngine;
using UnityEngine.InputSystem;

namespace NewInputSystem
{
    public class PlayerController0 : MonoBehaviour
    {
        private CharacterController cc;

        private Vector2 moveInput;
        public float speed = 5f;

        public InputActionAsset inputActionAsset;

        private InputAction moveAction;
        private InputAction jumpAction;
        private InputAction interactionAction;
        private InputAction attackAction;


        void Start()
        {
            moveAction = InputSystem.actions.FindAction("Move");
            jumpAction = InputSystem.actions.FindAction("Jump");
            interactionAction = InputSystem.actions.FindAction("Interaction");
            attackAction = InputSystem.actions.FindAction("Attack");

            cc = GetComponent<CharacterController>();
        }

        void Update()
        {
            moveInput = moveAction.ReadValue<Vector2>();

            if (moveInput != Vector2.zero)
            {
                Debug.Log("Move : " + moveAction.ReadValue<Vector2>());
                var dir = new Vector3(moveInput.x, 0, moveInput.y).normalized;

                cc.Move(dir * speed * Time.deltaTime);
            }

            if (jumpAction.WasPressedThisFrame()) // 1번 실행
            {
                Debug.Log("Jump");
            }

            if (interactionAction.IsPressed()) // 여러번 실행
            {
                Debug.Log("Interaction");
            }

            if (attackAction.WasPressedThisFrame())
            {
                Debug.Log("Attack");
            }

        }
    }
}
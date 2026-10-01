using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 1f;

    InputAction moveAction;
    Vector2 moveInput;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTorque();
   ///<summary>
   /// Applies Torque to the player based on the horizontal input from the Move Action
   /// <summary/>


    }
    void PlayerTorque{
             moveInput = moveAction.ReadValue<Vector2>();
        if (moveInput.x < 0)
        {
            rb.AddTorque(torqueAmount);
        }
        else if(moveInput.x > 0)
        {

        rb.AddTorque(torqueAmount);

        }
    }
}

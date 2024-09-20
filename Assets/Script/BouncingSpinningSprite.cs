
using UnityEngine;

public class ControlledSpinningSprite : MonoBehaviour
{
    public float speed = 5f;
    public float spinSpeed = 10f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Move the sprite in the XY plane
        rb.velocity = new Vector3(movement.x, movement.y, 0) * speed;

        // Rotate the sprite based on horizontal and vertical movement
        if (movement.x != 0 || movement.y != 0)
        {
            transform.Rotate(0, 0, spinSpeed * Time.deltaTime * (movement.x + movement.y - 2 * movement.x));
        }
    }
}
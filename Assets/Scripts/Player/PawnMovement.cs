using UnityEngine;

public class PawnMovement : MonoBehaviour {
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    public float turboMultiplier = 2f;

    private Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 input, bool turbo) {
        float speed = turbo ? moveSpeed * turboMultiplier : moveSpeed;
        rb.linearVelocity = transform.up * input.y * speed;
        rb.MoveRotation(rb.rotation - input.x * rotationSpeed * Time.fixedDeltaTime);
    }

    public void Teleport(Vector2 dir) {
        transform.position += (Vector3)dir;
    }

    public void RandomTeleport() {
        transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-5f, 5f));
    }
}

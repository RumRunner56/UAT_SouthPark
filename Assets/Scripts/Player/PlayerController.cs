using UnityEngine;

public class PlayerController : MonoBehaviour {
    private PawnMovement pawn;
    private ShooterBullet shooter;

    void Awake() {
        pawn = GetComponent<PawnMovement>();
        shooter = GetComponent<ShooterBullet>();
    }

    void Update() {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        bool turbo = Input.GetKey(KeyCode.LeftShift);

        pawn.Move(moveInput, turbo);

        if (Input.GetKeyDown(KeyCode.UpArrow)) pawn.Teleport(Vector2.up);
        if (Input.GetKeyDown(KeyCode.DownArrow)) pawn.Teleport(Vector2.down);
        if (Input.GetKeyDown(KeyCode.LeftArrow)) pawn.Teleport(Vector2.left);
        if (Input.GetKeyDown(KeyCode.RightArrow)) pawn.Teleport(Vector2.right);
        if (Input.GetKeyDown(KeyCode.T)) pawn.RandomTeleport();

        if (Input.GetButtonDown("Fire1")) shooter.Fire();
    }
}

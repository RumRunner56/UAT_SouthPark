using UnityEngine;

public class DeathPlayer : Death {
    public override void Die() {
        Debug.Log("Player died!");
        GameManager.Instance.Failure();
        Destroy(gameObject);
    }
}

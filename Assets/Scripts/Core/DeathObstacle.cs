using UnityEngine;

public class DeathObstacle : Death {
    public override void Die() {
        Debug.Log("Obstacle destroyed!");
        GameManager.Instance.Victory();
        Destroy(gameObject);
    }
}

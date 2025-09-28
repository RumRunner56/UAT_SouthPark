using UnityEngine;

public class ShooterBullet : MonoBehaviour {
    public GameObject projectilePrefab;

    public void Fire() {
        if (projectilePrefab != null) {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}

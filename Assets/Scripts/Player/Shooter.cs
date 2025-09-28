using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject projectilePrefab;
    public Transform firePoint;

    public void Fire() {
        if (projectilePrefab != null && firePoint != null) {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}

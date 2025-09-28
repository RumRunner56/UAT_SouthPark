using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed = 10f;
    public int damage = 1;
    public float lifeSeconds = 3f;

    void Start() {
        Destroy(gameObject, lifeSeconds);
    }

    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col) {
        HealthComponent health = col.GetComponent<HealthComponent>();
        if (health != null) {
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

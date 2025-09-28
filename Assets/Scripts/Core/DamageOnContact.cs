using UnityEngine;

public class DamageOnContact : MonoBehaviour {
    public int damage = 1;
    public bool instantKill = false;

    private void OnTriggerEnter2D(Collider2D col) {
        HealthComponent health = col.GetComponent<HealthComponent>();
        if (health != null) {
            if (instantKill) health.TakeDamage(999);
            else health.TakeDamage(damage);
        }
    }
}

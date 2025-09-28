using UnityEngine;

public class HealthComponent : MonoBehaviour {
    public int maxHealth = 3;
    private int currentHealth;
    private Death deathHandler;

    void Awake() {
        currentHealth = maxHealth;
        deathHandler = GetComponent<Death>();
    }

    public void TakeDamage(int amount) {
        currentHealth -= amount;
        if (currentHealth <= 0) {
            if (deathHandler != null) deathHandler.Die();
        }
    }
}

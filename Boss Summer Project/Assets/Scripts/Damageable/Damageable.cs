using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An abstract class for anything that has a form of HP, and a way to get damaged
public abstract class Damageable : MonoBehaviour
{
    public float maxHealth;
    public float health;

    public float maxAbsorptionHealth;
    public float absorptionHealth;

    public abstract void TakeDamage(float damage);

    public void Heal(float healAmount) {
        health += healAmount;
    }

    public void ResetHealth() {
        health = maxHealth;
    }

    public abstract void Die();
}

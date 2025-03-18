using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthAmount = 3;

    public void TakeDamage(int damageAmount) 
    {
        healthAmount -= damageAmount;
        GameFeel.AddCameraShake(0.1f);
        if (healthAmount <= 0) 
        {
            GameManager.instance.Restart();
        }
    }
    public static void TrydamageTarget(GameObject target, int damageAmount)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth) 
        {
            targetHealth.TakeDamage(damageAmount);
        }
    }
}

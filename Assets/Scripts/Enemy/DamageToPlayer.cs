using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    [SerializeField] int damage = 10;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "Player") return;

        PlayerHealth getPlayerHealth = col.GetComponent<PlayerHealth>();
        
        if (getPlayerHealth == null) return;
        getPlayerHealth.DoDamage(damage);

    }
}

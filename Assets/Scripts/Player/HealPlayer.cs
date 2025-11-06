using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    [SerializeField] int healHP = 10;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "Player") return;

        PlayerHealth getPlayerHealth = col.GetComponent<PlayerHealth>();

        if (getPlayerHealth == null || getPlayerHealth.IsDead()) return;

        getPlayerHealth.HealPlayer(healHP);
    }
}

using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int hp = 100;

    public void DoDamage(int damageValue = 0)
    {
        hp -= damageValue;
        CheckDeath(hp);
    }
    void CheckDeath(int hpToCheck = 0)
    {
        if (hpToCheck <= 0)
        {
            OnDead();
        }
    }

    void OnDead()
    {
        Destroy(gameObject);
    }
}

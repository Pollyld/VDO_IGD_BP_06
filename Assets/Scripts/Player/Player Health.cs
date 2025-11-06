using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int hp = 100;
    [SerializeField] int startHP = 100;
    [SerializeField] bool isDead = false;

    public int GetHP()
    {
        ClampHP();
        return hp;
    }

    public void SetHP(int hpValue = 0)
    {
        hp = hpValue;
        ClampHP();
    }

    public void HealPlayer(int healValue = 0)
    {
        hp += healValue;
        ClampHP();
    }

    void ClampHP()
    {
        hp = Mathf.Clamp(hp, 0, startHP);
    }
    /*
        //Alternatieve manier om onze hp te updaten via onze SetHP methode.
        SetHP(hp-damageValue);
        int tempHP = hp;
        tempHP -= damageValue;
        SetHP(tempHP);
    */

    void Start()
    {
        hp = startHP;
    }

    public void DoDamage(int damageValue = 0)
    {
        hp -= damageValue;
        ClampHP();
        CheckDeath(hp);
    }

    void CheckDeath(int hpToCheck = 0)
    {
        if (hpToCheck <= 0)
        {
            isDead = true;
            OnDead();
        }
    }

    void OnDead()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public bool IsDead() => isDead;
}

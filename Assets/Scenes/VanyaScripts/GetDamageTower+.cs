using UnityEngine;

public class GetDamageTower : MonoBehaviour
{
    [SerializeField]float hp;
    public GameObject game;

    public void Damage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(game, 2f);
        }
    }

    public void ReturnHp(ref float _hp)
    {
        _hp = hp;

    }

    
}

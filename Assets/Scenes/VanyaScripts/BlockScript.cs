using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] private int hp;
    public int resistenceShield;
    

    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject, 5f);


        }
    }
    public void ReturnHp(ref int _hp)
    {
        _hp = hp;

    }
}



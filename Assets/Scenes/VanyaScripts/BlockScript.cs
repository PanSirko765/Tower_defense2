using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] private float hp;
    public int resistenceShield;
    

    public void Damage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject, 5f);


        }
    }
    public void ReturnHp(ref float _hp)
    {
        _hp = hp;

    }
}



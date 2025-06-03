using UnityEngine;

public class TowerScript : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private float damage;
    [SerializeField] private bool invisbleSee;


    public void Damage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject, 5f);
        }
    }

    public void ReturnHp(ref int _hp) { 
        _hp = hp;
    
    }
}

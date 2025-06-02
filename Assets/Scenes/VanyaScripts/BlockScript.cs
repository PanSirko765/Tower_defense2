using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] private int hp;
    public int resistenceShield;
    [SerializeField] private bool invisbleSee;

    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);


        }
    }
}



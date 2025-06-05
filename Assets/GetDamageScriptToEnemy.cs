using UnityEngine;

public class GetDamageScriptToEnemy : MonoBehaviour
{
    public float hp;
    public GameObject @object;
    public bool isInvisble;

    public void Damage(float _damage)
    {
        hp -= _damage;
        if (hp <= 0)
        {
            Destroy(@object, 2f);

        }
    }

    public void ReturnHp(ref float _hp)
    {
        _hp = hp;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Roocket")
        {
            Damage(90);
        }
    }
}

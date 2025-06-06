using UnityEngine;

public class BulletS : MonoBehaviour
{
    public Rigidbody rb;
    private float Damage = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 10f);
    }

    public void SetTower(TowerScript towerSkript)
    {
        Damage = towerSkript.damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GetDamageScriptToEnemy enemyScript = other.gameObject.GetComponent<GetDamageScriptToEnemy>();
            enemyScript.Damage(Damage);
            Destroy(gameObject);
        }
    }
}

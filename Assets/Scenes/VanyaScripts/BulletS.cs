using UnityEngine;

public class BulletS : MonoBehaviour
{
    public Rigidbody rb;
    private int Damage = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 2f);
    }

    public void SetTower(TowerScript towerSkript)
    {
        Damage = towerSkript.damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyScript enemyScript = other.gameObject.GetComponent<EnemyScript>();
            enemyScript.Damage(Damage);
            Destroy(gameObject);
        }
    }
}

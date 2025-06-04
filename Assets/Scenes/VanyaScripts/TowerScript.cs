using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerScript : MonoBehaviour
{
    [SerializeField] private float hp;
    public float damage;
    [SerializeField] private bool invisbleSee;
    [SerializeField] private bool notInvisbleSee;
    [SerializeField]
    private float Time_;
    [SerializeField]
    private float bulletSpeed = 25;
    private float time;
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField] private bool isRocket;
    [SerializeField] private bool isShoker;
    [SerializeField] private float slowing;
    [SerializeField] private bool isFan;
    public void Damage(float damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject, 5f);
        }
    }

    public void ReturnHp(ref float _hp) { 
        _hp = hp;
    
    }

    private HashSet<GameObject> objectsInTrigger = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyScript enemyScript = other.GetComponent<EnemyScript>();
            if (enemyScript.isInvisble)
            {
                if (invisbleSee)
                {
                    objectsInTrigger.Add(other.gameObject);
                }
            }
            else if (!enemyScript.isInvisble)
            {
                if (notInvisbleSee)
                {
                    objectsInTrigger.Add(other.gameObject);
                }
            }
        }
            
    }

    private void Update()
    {
        // Очистка удалённых объектов
        objectsInTrigger.RemoveWhere(collider => collider == null);

        if (objectsInTrigger.Count > 0)
        {

            time += Time.deltaTime;

            if (time > Time_)
            {
                foreach (var item in objectsInTrigger)
                {
                    Shoot(item.transform, item);

                }
                time = 0;
            }
        }
    }

    [SerializeField]
    private Transform firePoint;
    private void Shoot(Transform enemy, GameObject gameObject)
    {
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, Quaternion.identity);
        if (!isRocket)
        {
            if (!isFan)
            {
                BulletS buulet = bullet.GetComponent<BulletS>();
                buulet.SetTower(this);
                Vector3 dir = (enemy.position - firePoint.position).normalized;
                buulet.rb.AddForce(dir * bulletSpeed);
                if (isShoker)
                {
                    NavMeshAgent navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
                    navMeshAgent.speed *= slowing;

                }

            }
            else
            {
                NavMeshAgent navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
                navMeshAgent.speed *= slowing;
            }
        }
        else
        {
            RocketScript buulet = bullet.GetComponent<RocketScript>();
            buulet.SetTower(this);
            Vector3 dir = (enemy.position - firePoint.position).normalized;
            buulet.rb.AddForce(dir * bulletSpeed);
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    [SerializeField] private int hp;
    public int damage;
    [SerializeField] private bool invisbleSee;
    [SerializeField]
    private float Time_;
    [SerializeField]
    private float bulletSpeed = 25;
    private float time;
    [SerializeField]
    private GameObject BulletPrefab;

    


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

    private HashSet<GameObject> objectsInTrigger = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            objectsInTrigger.Add(other.gameObject);
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
                    Shoot(item.transform);
                    break;
                }
                time = 0;
            }
        }
    }

    [SerializeField]
    private Transform firePoint;
    private void Shoot(Transform enemy)
    {
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, Quaternion.identity);
        BulletS buulet = bullet.GetComponent<BulletS>();
        buulet.SetTower(this);
        Vector3 dir = (enemy.position - firePoint.position).normalized;
        buulet.rb.AddForce(dir * bulletSpeed);

    }
}

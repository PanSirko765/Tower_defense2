using System.Collections.Generic;
using UnityEngine;

public class DJScript : MonoBehaviour
{
    [SerializeField] private float hp;
    public float _boostDamage;
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

    private HashSet<GameObject> objectsInTrigger = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tower"))
        {
            objectsInTrigger.Add(other.gameObject);
        }

    }

    private void Update()
    {
        // Очистка удалённых объектов
        objectsInTrigger.RemoveWhere(collider => collider == null);

        if (objectsInTrigger.Count > 0)
        {
                foreach (var item in objectsInTrigger)
                {
                Shoot(item);
                }
        }
    }

    private void Shoot(GameObject enemy)
    {
        TowerScript towerScript = enemy.GetComponent<TowerScript>();
        towerScript.damage *= _boostDamage;
    }
}

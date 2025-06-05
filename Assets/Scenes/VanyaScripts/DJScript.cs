using System.Collections.Generic;
using UnityEngine;

public class DJScript : MonoBehaviour
{
    
    public float _boostDamage;
    

    private HashSet<GameObject> objectsInTrigger = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
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

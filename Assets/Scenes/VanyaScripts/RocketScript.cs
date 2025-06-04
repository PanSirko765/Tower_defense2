using Unity.Properties;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public Rigidbody rb;
    public float Damage = 1;
    [SerializeField] private GameObject gameObject;

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
            gameObject.SetActive(true);
            rockerdamage rockerdamage = gameObject.GetComponent< rockerdamage>();
            rockerdamage.SetTower(this);

            
        }
    }
}

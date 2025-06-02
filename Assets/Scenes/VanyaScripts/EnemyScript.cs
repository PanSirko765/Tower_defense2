using System.Runtime.Serialization;
using UnityEditor;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]private int hp;
    [SerializeField]private int damage;
    [SerializeField]private float reDamage;
    [SerializeField] private bool isTht;
    private float time;

    private void Start()
    {
        time = reDamage;
    }
    public void Damage(int _damage)
    {
        hp -= _damage;
        if(hp <= 0)
        {
           Destroy(gameObject);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (!isTht) 
        {
            if (other.gameObject.tag == "Tower") { 
                
                TowerScript towerScript = other.gameObject.GetComponent<TowerScript>();
                time -= Time.deltaTime;
                if (time < 0) {
                    time = reDamage;
                    towerScript.Damage(damage);
                
                
                }
                
            
            }
            else if(other.gameObject.tag == "Block")
            {
                BlockScript blockScript = other.gameObject.GetComponent<BlockScript>();
                time -= Time.deltaTime;
                if (time < 0) {
                    time = reDamage;
                    blockScript.Damage(damage);
                
                
                }
            }
      
        }
    }

    public void ReturnDamage(ref int _damage)
    {
        _damage = damage;
    }




}

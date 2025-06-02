using System.Runtime.Serialization;
using UnityEditor;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]private int hp;
    [SerializeField]private int damage;
    [SerializeField]private float reDamage;
    [SerializeField] private bool isTht;
    

    public void Damage(int _damage)
    {
        hp -= _damage;
        if(hp <= 0)
        {
           Destroy(gameObject);
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!isTht) 
        { 
           ObjectIDGenerator.Equals(false, false);
        
        }
    }

    public void ReturnDamage(ref int _damage)
    {
        _damage = damage;
    }




}

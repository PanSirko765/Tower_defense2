using System.Runtime.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public int hpTarget;
    [SerializeField]private int hp;
    [SerializeField]private int damage;
    [SerializeField]private float reDamage;
    [SerializeField] private bool isTht;
    public bool isInvisble;
    public NavMeshAgent agent;
    public bool _isAttack;
    private float time;
    
    public GameObject targetObj;

    private void Start()
    {
        time = reDamage;
        Prioryty();
    }
    private void FixedUpdate()
    {
        if (_isAttack == false)
        {
            Prioryty();

        }
       
    }
    public void Prioryty()
    {
        agent.SetDestination(targetObj.transform.position);
    }
    public void Damage(int _damage)
    {
        hp -= _damage;
        if(hp <= 0)
        {
            Destroy(gameObject, 2f);
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
                    _isAttack = true;
                    agent.SetDestination(other.gameObject.transform.position);
                    towerScript.ReturnHp(ref hpTarget);
                    if(hpTarget <= 0)
                    {
                        _isAttack=false;
                        Prioryty();
                    }

                
                }
                
            
            }
            else if(other.gameObject.tag == "Block")
            {
                BlockScript blockScript = other.gameObject.GetComponent<BlockScript>();
                time -= Time.deltaTime;
                if (time < 0) {
                    time = reDamage;
                    blockScript.Damage(damage);
                    _isAttack = true;
                    agent.SetDestination(other.gameObject.transform.position);
                    blockScript.ReturnHp(ref hpTarget);
                    if (hpTarget <= 0) { _isAttack = false; Prioryty(); }
                }
            }
      
        }
        else
        {
            if (other.gameObject.tag == "Tower")
            {
                Destroy(other.gameObject, 1f);
                isTht = false;

            }
            else if (other.gameObject.tag == "Block")
            {
                BlockScript blockScript = other.gameObject.GetComponent<BlockScript>();
                if (blockScript.resistenceShield <= 0)
                {
                    Destroy(other.gameObject, 1f);
                }
                else
                {
                    blockScript.resistenceShield -= 1;
                }
                isTht = false;
            }
        }
    }

    public void ReturnDamage(ref int _damage)
    {
        _damage = damage;
    }




}

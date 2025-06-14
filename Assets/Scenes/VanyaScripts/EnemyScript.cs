using System.Runtime.Serialization;

using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public float hpTarget;
    
    [SerializeField]private float damage;
    [SerializeField]private float reDamage;
    [SerializeField] private bool isTht;
    
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
    

    private void OnTriggerStay(Collider other)
    {
        if (!isTht) 
        {
            if (other.gameObject.tag == "Tower") { 
                
                GetDamageTower towerScript = other.GetComponent<GetDamageTower>();
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
            else if(other.gameObject.tag == "Barricade")
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
            else if(other.gameObject.tag == "DJ")
            {
                GetDamageTower towerScript = other.gameObject.GetComponent<GetDamageTower>();
                time -= Time.deltaTime;
                if (time < 0)
                {
                    time = reDamage;
                    towerScript.Damage(damage);
                    _isAttack = true;
                    agent.SetDestination(other.gameObject.transform.position);
                    towerScript.ReturnHp(ref hpTarget);
                    if (hpTarget <= 0)
                    {
                        _isAttack = false;
                        Prioryty();
                    }


                }
            }
            
      
        }
        else
        {
            if (other.gameObject.tag == "Tower")
            {
                GetDamageTower towerScript = other.GetComponent<GetDamageTower>();
                towerScript.Damage(1000000);
                isTht = false;

            }
            
            
        }
    }

    public void ReturnDamage(ref float _damage)
    {
        _damage = damage;
    }




}

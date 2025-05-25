using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class TheBomberScript : MonoBehaviour
{
    [SerializeField]
    private GameObject gameobject;
    [SerializeField]
    private GameObject gameobject2;
    [SerializeField]
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

          Destroy(gameobject);
          Destroy(gameobject2,15f);


        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            agent.speed+=0.01f;
            if (agent.speed >= 40)
            {
                agent.speed = 40;
            }
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

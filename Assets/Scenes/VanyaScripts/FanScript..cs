using UnityEngine;
using UnityEngine.AI;

public class FanScript : MonoBehaviour
{
    [SerializeField] float slowing;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "New Tag")
        {
            NavMeshAgent navMeshAgent = other.gameObject.GetComponent<NavMeshAgent>();
            navMeshAgent.speed *= slowing;
        }
    }

}

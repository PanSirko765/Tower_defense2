using UnityEngine;
using UnityEngine.AI;

public class HiddenShieldScript : MonoBehaviour
{

    [SerializeField]
    private Animation animation;
    [SerializeField]
    private GameObject gameobject;
    [SerializeField]
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            animation.Play();
            Destroy(gameobject);

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (agent.speed >= 30)
        {
            agent.speed = 30;
        }
        agent.speed += 0.01f;

    }
}

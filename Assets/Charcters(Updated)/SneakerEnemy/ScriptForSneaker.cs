using UnityEngine;

public class ScriptForSneaker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private Animation animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            animation.Play();


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

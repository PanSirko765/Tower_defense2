using UnityEngine;

public class scriptforgun : MonoBehaviour
{
    [SerializeField]
    private Animation animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerStay(Collider other)
    {
        if ( other.gameObject.tag == "Tower" || other.gameObject.tag == "")
        {

            animation.Play();

        }
    }
    void Update()
    {

    }
}


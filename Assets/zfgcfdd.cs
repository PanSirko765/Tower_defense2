using UnityEngine;
using UnityEngine.SceneManagement;

public class zfgcfdd : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        
    }
}

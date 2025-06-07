using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterToLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}

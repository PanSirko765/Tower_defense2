using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefetScript : MonoBehaviour
{
    public GameObject game;
    float time = 50;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            game.SetActive(true);
            time -= Time.deltaTime;
            if(time < 0)
            {
                game.SetActive(false);
                SceneManager.LoadScene(2);
            }

            
        }
    }

    
}

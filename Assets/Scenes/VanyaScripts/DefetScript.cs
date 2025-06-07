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
            
            
                SceneManager.LoadScene(2);
            

            
        }
    }

    
}

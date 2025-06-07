using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterToLevel : MonoBehaviour
{
    private void OnMouseDown()
    {
        
        
         SceneManager.LoadScene(3);
        
    }
}

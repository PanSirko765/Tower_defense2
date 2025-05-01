using UnityEditor.Rendering.PostProcessing;
using UnityEngine;

public class AnimRayCast : MonoBehaviour
{
    public Animation animation;
    public Camera camera;
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            
            
                //animation.Play("ButtonAnim");
                Debug.Log(hit.transform.name);
             
            
        }
    }
}

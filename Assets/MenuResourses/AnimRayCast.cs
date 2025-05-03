using UnityEditor.Rendering.PostProcessing;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimRayCast : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animation animation;
    public Camera camera;

    public void OnPointerEnter(PointerEventData eventData)
    {
        animation.Play("ButtonAnim 1");
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animation.Play("ButtonAnim");
        
    }
}

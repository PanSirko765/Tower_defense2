
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimRayCast : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator animator;
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("Down", true);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("Down", false);

    }
}

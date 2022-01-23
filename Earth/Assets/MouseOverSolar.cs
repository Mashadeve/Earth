using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverSolar : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator solarButtonAnimator;

    private void Awake()
    {
        solarButtonAnimator = GetComponentInChildren<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        solarButtonAnimator.SetBool("MouseEnter", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        solarButtonAnimator.SetBool("MouseEnter", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseOverEarth : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator earthButtonAnimator;

    private void Awake()
    {
        earthButtonAnimator = GetComponentInChildren<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        earthButtonAnimator.SetBool("MouseEnter", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       earthButtonAnimator.SetBool("MouseEnter", false);
    }



}

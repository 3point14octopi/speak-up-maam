using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoffeeMachineButton : MonoBehaviour, IPointerClickHandler
{
    public int strength;
    public GameObject coffeeMachine;
    public Animator anim;
    public AnimationClip pressAnimation;
    public void OnPointerClick(PointerEventData eventData)
    {
        //coffeeMachine.GetComponent<CoffeeMachine>().SetStrength(strength);
        anim.Play(pressAnimation.name);
    }
}

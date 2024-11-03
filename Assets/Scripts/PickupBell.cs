using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickupBell : MonoBehaviour, IPointerClickHandler
{
    public GameObject cup;
    public Animator anim;
    public AnimationClip ring;
    public GameObject speechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        speechBubble.SetActive(true);
        cup.GetComponent<Dialogic>().Check();
        cup.GetComponent<Pickup>().HideCup();
        anim.Play(ring.name);
    }
}

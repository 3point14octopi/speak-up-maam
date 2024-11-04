using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlavourPump : MonoBehaviour, IPointerClickHandler, IDropHandler
{
    public GameObject cup;
    public Flavours flavour;
    public Animator anim;
    public GameObject pump;
    public AnimationClip[] pumpAnims;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (cup.transform.IsChildOf(transform))
        {
            cup.GetComponent<Dialogic>().selectedFlavour = flavour;
            anim.Play(pumpAnims[(int)cup.GetComponent<Dialogic>().selectedSize].name);
            pump.transform.SetAsLastSibling();
            gameObject.GetComponent<AudioSource>().Play(0);
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject item = eventData.pointerDrag;
        if (item.tag == "Cup" && cup.GetComponent<Dialogic>().progress == 2)
        {
            item.GetComponent<Pickup>().hidden = false;
            item.GetComponent<Pickup>().parentAfterDrag = transform;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GarbageBin : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {

        GameObject item = eventData.pointerDrag;
        if (item.tag == "Cup")
        {
            item.GetComponent<Pickup>().HideCup();
            item.GetComponent<Dialogic>().WipeCurrentCoffee();
            gameObject.GetComponent<AudioSource>().Play(0);
        }
    }
}

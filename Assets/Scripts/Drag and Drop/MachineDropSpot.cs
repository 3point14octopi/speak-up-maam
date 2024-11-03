using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class MachineDropSpot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {

        GameObject item = eventData.pointerDrag;
        Debug.Log(item.tag);
        if (item.tag == "Stack")
        {
            Debug.Log("machine dropoff");
            item.GetComponent<CupSelect>().cup.GetComponent<Pickup>().hidden = false;
            item.GetComponent<CupSelect>().cup.GetComponent<Pickup>().parentAfterDrag = transform;
        }
    }
}

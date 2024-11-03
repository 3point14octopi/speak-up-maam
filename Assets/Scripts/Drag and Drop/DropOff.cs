using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropOff : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("dropoff");
        GameObject item = eventData.pointerDrag;
        Debug.Log(item.tag);
        if (item.tag == "Cup")
        {
            item.GetComponent<Pickup>().hidden = false;
            item.GetComponent<Pickup>().parentAfterDrag = transform;
        }
    }

}

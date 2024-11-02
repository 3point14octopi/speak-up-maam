using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropOff : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData evemtData)
    {
        GameObject item = evemtData.pointerDrag;
        item.GetComponent<Pickup>().parentAfterDrag = transform;
    }

}

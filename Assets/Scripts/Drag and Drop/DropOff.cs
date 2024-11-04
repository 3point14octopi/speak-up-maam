using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static Unity.Burst.Intrinsics.X86.Avx;

public class DropOff : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject item = eventData.pointerDrag;
        if (item.tag == "Cup" && item.GetComponent<Dialogic>().progress == 2)
        {
            item.GetComponent<Pickup>().hidden = false;
            item.GetComponent<Pickup>().parentAfterDrag = transform;
        }
    }

}

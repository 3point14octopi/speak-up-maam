using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;


public class MachineDropSpot : MonoBehaviour, IDropHandler
{
    public GameObject cup;
    public Slider slider;


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

    public void PourCoffee(Scale3Vals caffiene)
    {
        cup.GetComponent<Dialogic>().selectedStrength = caffiene;
        cup.GetComponent<Dialogic>().selectedTemperature = (Scale3Vals) slider.value;
        cup.GetComponent<CupSpriteHandler>().FillSprite();
    }
}

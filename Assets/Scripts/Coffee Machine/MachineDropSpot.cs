using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;


public class MachineDropSpot : MonoBehaviour, IDropHandler
{
    public GameObject cup;
    public Slider slider;
    public GameObject nozzle;
    public AnimationClip[] nozzleAnims;


    public void OnDrop(PointerEventData eventData)
    {

        GameObject item = eventData.pointerDrag;
        if (item.tag == "Stack")
        {
            item.GetComponent<CupSelect>().cup.GetComponent<Pickup>().hidden = false;
            item.GetComponent<CupSelect>().cup.GetComponent<Pickup>().parentAfterDrag = transform;
        }
    }

    public void PourCoffee(Scale3Vals caffiene)
    {
        cup.GetComponent<Dialogic>().selectedStrength = caffiene;
        cup.GetComponent<Dialogic>().selectedTemperature = (Scale3Vals) slider.value;
        cup.GetComponent<Dialogic>().progress = 2;
        cup.GetComponent<CupSpriteHandler>().FillSprite();
        nozzle.transform.SetAsLastSibling();
        nozzle.GetComponent<Animator>().Play(nozzleAnims[(int)cup.GetComponent<Dialogic>().selectedSize].name);
        gameObject.GetComponent<AudioSource>().Play(0);
    }
}

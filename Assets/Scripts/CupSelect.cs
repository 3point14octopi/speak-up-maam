using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CupSelect : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject cup;
    public int cupSize;


    // Update is called once per frame

    public void OnBeginDrag(PointerEventData evemtData)
    {
        cup.GetComponent<CupSpriteHandler>().SetCupSize(cupSize);
        cup.GetComponent<Dialogic>().selectedSize = (Scale3Vals)cupSize;
        cup.transform.SetParent(transform.root); // becomes a child off the UI 
        cup.transform.SetAsLastSibling(); //becomes the last child this makes it so it is the closest to the camera and wont pass under things
        cup.GetComponent<Image>().raycastTarget = false; //no ray on drag
    }

    public void OnDrag(PointerEventData evemtData)
    {
        cup.transform.position = Input.mousePosition; //Lets the object stay under the mouse using events 
    }

    public void OnEndDrag(PointerEventData evemtData)
    {

        if (cup.GetComponent<Pickup>().hidden == false) {
            cup.transform.SetParent(cup.GetComponent<Pickup>().parentAfterDrag);
            cup.GetComponent<Image>().raycastTarget = true; //no ray on drag
        }
        else
        {
            cup.GetComponent<Pickup>().HideCup();
            cup.GetComponent<Dialogic>().WipeCurrentCoffee();

        }
    }
}

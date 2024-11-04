using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Pickup : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Start is called before the first frame update
    // IPointerEnterHandler, IPointerExitHandler,, IDropHandler
    private Image image;
    public Transform parentAfterDrag; 
    public GameObject hiddenSpot; //used to hide the coffee cup off screen
    public bool hidden = true;
    void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideCup()
    {
        transform.SetParent(hiddenSpot.transform);
        hidden = true;
        parentAfterDrag = null;
    }

    public void OnBeginDrag(PointerEventData evemtData)
    {
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root); // becomes a child off the UI 
            transform.SetAsLastSibling(); //becomes the last child this makes it so it is the closest to the camera and wont pass under things
            image.raycastTarget = false; //no ray on drag
    }

    public void OnDrag(PointerEventData evemtData)
    {

            transform.position = Input.mousePosition; //Lets the object stay under the mouse using events 

    }

    public void OnEndDrag(PointerEventData evemtData)
    {

            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true; //no ray on drag
        
    }
}

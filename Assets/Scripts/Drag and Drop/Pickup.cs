using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static System.Net.Mime.MediaTypeNames;

public class Pickup : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    // Start is called before the first frame update
    // IPointerEnterHandler, IPointerExitHandler, , IEndDragHandler, IDropHandler
    private Image image;
    void Start()
    {
        image = gameObject.Get
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData evemtData)
    {
        //parentAfterDrag = transform.parent;
        transform.SetParent(transform.root); // becomes a child off the UI 
        transform.SetAsLastSibling(); //becomes the last child this makes it so it is the closest to the camera and wont pass under things
        image.raycastTarget = false; //no ray on drag
    }

    public void OnDrag(PointerEventData evemtData)
    {

        transform.position = Input.mousePosition; //Lets the object stay under the mouse using events 
    }
}

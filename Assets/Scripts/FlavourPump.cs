using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlavourPump : MonoBehaviour, IPointerClickHandler
{
    public GameObject cup;
    public Flavours flavour;
    public Animator anim;
    public GameObject pump;
    public AnimationClip[] pumpAnims;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        cup.GetComponent<Dialogic>().selectedFlavour = flavour;
        anim.Play(pumpAnims[(int)cup.GetComponent<Dialogic>().selectedSize].name);
        pump.transform.SetAsLastSibling();
    }
}

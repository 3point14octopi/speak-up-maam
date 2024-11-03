using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupSpriteHandler : MonoBehaviour
{
    public Image image;
    public Sprite[] SmallCups;
    public Vector2 SmallSize = new Vector2();

    public Sprite[] MediumCups;
    public Vector2 MediumSize = new Vector2();
    
    public Sprite[] TallCups;
    public Vector2 TallSize = new Vector2();

    public Sprite closedCup;


    public void SetCupSize(int size)
    {
        if (size == 0)
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = SmallSize;
            image.sprite = SmallCups[0];
            closedCup = SmallCups[1];
        }

        else if (size == 1)
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = MediumSize;
            image.sprite = MediumCups[0];
            closedCup = MediumCups[1];
        }
        else if (size == 2)
        {

            gameObject.GetComponent<RectTransform>().sizeDelta = TallSize;
            image.sprite = TallCups[0];
            closedCup = TallCups[1];
        }
    }
}

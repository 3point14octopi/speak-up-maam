using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderSound : MonoBehaviour
{
 public void SliderSound()
    {
        gameObject.GetComponent<AudioSource>().Play(0);
    }
}

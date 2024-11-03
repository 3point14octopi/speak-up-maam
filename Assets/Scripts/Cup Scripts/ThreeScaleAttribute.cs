using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Used when an attribute has three related states.
/// For example: if something should be big, medium, or small
/// </summary>
[CreateAssetMenu(fileName = "3Scale Attribute", menuName = "CoffeeAttributes/Three Scale", order = 1)]
[Serializable]public class ThreeScaleAttribute : ScriptableObject
{
    protected Scale3Vals myVal;
    public TextMeshProUGUI speechBubble;
    bool incorrect = true;

    public List<string> xLowComplain = new List<string>();
    public List<string> lowComplain = new List<string>();
    public List<string> highComplain = new List<string>();
    public List<string> xHighComplain = new List<string>();

    public void SetValue(Scale3Vals newVal)
    {
        myVal = newVal;
    }

    public bool CompareAttribute(Scale3Vals compareVal)
    {
        incorrect = false;
        if (myVal == compareVal + 2)
        {
            Complain(xLowComplain);
        }
        else if (myVal == compareVal + 1)
        {
            Complain(lowComplain);
        }
        else if (myVal == compareVal - 1)
        {
            Complain(highComplain);
        }
        else if (myVal == compareVal - 2)
        {
            Complain(xHighComplain);
        }

        return incorrect;
    }

    /// <summary>
    /// edit this function to change where the complaint is outputted
    /// </summary>
    /// <param name="complaintPool"></param>
    public void Complain(List<string> complaintPool)
    {
        speechBubble.text += "\n" + complaintPool[UnityEngine.Random.Range(0, complaintPool.Count)];
        incorrect = true;
    }

    public void GiveText(TextMeshProUGUI a)
    {
        speechBubble = a;
    }
}
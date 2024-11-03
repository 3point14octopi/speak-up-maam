using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]public class ComplaintList
{
    public List<string> cList = new List<string>();
}

/// <summary>
/// Used when an attribute has a number of independent states. 
/// For example: if something should be chocolate, vanilla, or strawberry
/// </summary>
[CreateAssetMenu(fileName = "Unlinked Attribute", menuName = "CoffeeAttributes/Unlinked Attribute", order = 2)]
[Serializable]public class UnlinkedAttribute : ScriptableObject
{
    public TMP_Text speechBubble;
    protected Flavours value;
    bool incorrect = true;

    [SerializeField] public List<ComplaintList> complaints = new List<ComplaintList>();

    public void SetValue(Flavours newVal)
    {
        value = newVal;
    }

    public bool CompareAttribute(Flavours compareVal)
    {
        incorrect = false;

        if(compareVal != value)
        {
            DropHint(complaints[(int)value].cList);
        }
        return incorrect;
    }

    /// <summary>
    /// edit this function to change where the complaint is outputted
    /// </summary>
    /// <param name="complaintPool"></param>
    public void DropHint(List<string> complaintPool)
    {
        speechBubble.text += "\n" + complaintPool[UnityEngine.Random.Range(0, complaintPool.Count)];
        incorrect = true;
    }
    public void GiveText(TextMeshProUGUI a)
    {
        speechBubble = a;
    }
}

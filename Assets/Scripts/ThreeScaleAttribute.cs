﻿using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "3Scale Attribute", menuName = "CoffeeAttributes/Three Scale", order = 1)]
[Serializable]public class ThreeScaleAttribute : ScriptableObject
{
    [SerializeField] protected Scale3Vals myVal;
    bool incorrect = true;

    //change this
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

    public void Complain(List<string> complaintPool)
    {
        Debug.Log(complaintPool[UnityEngine.Random.Range(0, complaintPool.Count)]);
        incorrect = true;
    }
}
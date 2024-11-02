using System.Collections.Generic;
using UnityEngine;

public class ThreeScale : MonoBehaviour
{
    [SerializeField]protected Scale3Vals myVal;
    bool incorrect = true;

    //change this
    public List<string> xLowComplain  = new List<string>();
    public List<string> lowComplain  = new List<string>();
    public List<string> highComplain = new List<string>();
    public List<string> xHighComplain = new List<string>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetValue(Scale3Vals newVal)
    {
        myVal = newVal;
    }

    public bool CompareAttribute(Scale3Vals compareVal)
    {
        incorrect = false;
        if(myVal == compareVal + 2)
        {
            Complain(xLowComplain);
        }else if(myVal == compareVal + 1)
        {
            Complain(lowComplain);
        }else if(myVal == compareVal - 1)
        {
            Complain(highComplain);
        }else if(myVal == compareVal - 2)
        {
            Complain(xHighComplain);
        }

        return incorrect;
    }

    public void Complain(List<string> complaintPool)
    {
        Debug.Log(complaintPool[Random.Range(0, complaintPool.Count)]);
        incorrect = true;
    }
}
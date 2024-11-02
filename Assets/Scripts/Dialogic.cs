using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public enum Scale3Vals
{
    LOW = 0,
    MID = 1,
    HIGH = 2
}







public class Dialogic:MonoBehaviour
{
    public ThreeScaleAttribute temperature;
    public ThreeScaleAttribute size;
    public ThreeScaleAttribute strength;

    public Scale3Vals selectedTemperature;
    public Scale3Vals selectedSize;
    public Scale3Vals selectedStrength;



    // Start is called before the first frame update
    void Start()
    {
        Shuffle(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check();
        }
    }

    public void Check()
    {
        bool wrong = false;

        wrong = (temperature.CompareAttribute(selectedTemperature))?true:wrong;
        wrong = (size.CompareAttribute(selectedSize))?true:wrong;
        wrong = (strength.CompareAttribute(selectedStrength))?true:wrong;

        if (!wrong)
        {
            Debug.Log("u dids it");
            Shuffle();
        }
    }

    void Shuffle(bool shuffleAll = false)
    {
        temperature.SetValue((Scale3Vals)Random.Range(0, 3));
        size.SetValue((Scale3Vals)Random.Range(0, 3));
        strength.SetValue((Scale3Vals)Random.Range(0, 3));

        if (!shuffleAll) return;

        selectedTemperature = (Scale3Vals)Random.Range(0, 3);
        selectedSize = (Scale3Vals)Random.Range(0, 3);
        selectedStrength = (Scale3Vals)Random.Range(0, 3);
    }
}

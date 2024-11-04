using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public enum Scale3Vals
{
    NULL = -1,
    LOW  =  0,
    MID  =  1,
    HIGH =  2
}

public enum Flavours
{
    NONE     = 0,
    PSPICE   = 1,
    CARAMEL  = 2,
    HAZELNUT = 3,
    VANILLA  = 4
}






public class Dialogic:MonoBehaviour
{
    [SerializeField] ThreeScaleAttribute temperature;
    [SerializeField] ThreeScaleAttribute size;
    [SerializeField] ThreeScaleAttribute strength;
    [SerializeField] UnlinkedAttribute   flavour;
    public TextMeshProUGUI speechBubble;

    public Scale3Vals selectedTemperature;
    public Scale3Vals selectedSize;
    public Scale3Vals selectedStrength;
    public Flavours selectedFlavour;
    public GameObject customer;
    public GameObject score;
    public int progress = 0;
    



    // Start is called before the first frame update
    void Start()
    {
        Shuffle();
        temperature.GiveText(speechBubble);
        size.GiveText(speechBubble);
        strength.GiveText(speechBubble);
        flavour.GiveText(speechBubble);
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
        speechBubble.text = "";
        if(selectedSize == Scale3Vals.NULL || selectedTemperature == Scale3Vals.NULL || selectedStrength == Scale3Vals.NULL)
        {
            Debug.Log("incomplete order!");
            WipeCurrentCoffee();
            return;
        }

        bool wrong = false;

        wrong = (temperature.CompareAttribute(selectedTemperature))?true:wrong;
        wrong = (size.CompareAttribute(selectedSize))?true:wrong;
        wrong = (strength.CompareAttribute(selectedStrength))?true:wrong;
        wrong = (flavour.CompareAttribute(selectedFlavour)) ? true : wrong;

        if (!wrong)
        {
            Debug.Log("u dids it");
            customer.GetComponent<Customer>().Leave();
            score.GetComponent<ScoreTimer>().UpdateScore();
            Shuffle();
        }
        else
        {
            WipeCurrentCoffee();
        }
    }

    void Shuffle(bool shuffleAll = false)
    {
        temperature.SetValue((Scale3Vals)Random.Range(0, 3));
        size.SetValue((Scale3Vals)Random.Range(0, 3));
        strength.SetValue((Scale3Vals)Random.Range(0, 3));
        flavour.SetValue((Flavours)Random.Range(0, flavour.complaints.Count));
        
        WipeCurrentCoffee();
    }

    public void WipeCurrentCoffee()
    {
        selectedTemperature = Scale3Vals.NULL;
        selectedSize        = Scale3Vals.NULL;
        selectedStrength    = Scale3Vals.NULL;
        selectedFlavour     = Flavours.NONE;
        progress = 0;
    }
}

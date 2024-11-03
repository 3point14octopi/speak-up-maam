using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public Sprite[] CustomerImages;
    public Image image;
    public Animator anim;
    public AnimationClip walkout;
    public GameObject textBubble;
    public TextMeshProUGUI speechBubble;
    public string[] fakeOrders;
    private int currentCustomer = 1;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        RandomCustomer();
        StartCoroutine(WalkIn());
    }
    public  void Leave()
    {
        StartCoroutine(LeaveAnimation());
    }
    private void RandomCustomer()
    {
        int a = Random.Range(0, 14);
        while (a == currentCustomer) a = Random.Range(0, 14); 

        image.sprite = CustomerImages[a];
        currentCustomer = a;
    }


    private IEnumerator LeaveAnimation()
    {
        textBubble.SetActive(false);
        anim.Play(walkout.name);
        yield return new WaitForSeconds(1.6f);
        RandomCustomer();
        StartCoroutine(WalkIn());
    }

    private IEnumerator WalkIn()
    {
        yield return new WaitForSeconds(1.6f);
        textBubble.SetActive(true);
        speechBubble.text = "\n" + fakeOrders[Random.Range(0, 3)];
        yield return new WaitForSeconds(2.5f);
        textBubble.SetActive(false);

    }
}

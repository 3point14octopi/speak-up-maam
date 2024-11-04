using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;     
    }
    public void TutorialClose()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}

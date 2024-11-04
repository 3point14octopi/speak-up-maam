using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    public Button fontButton;
    public Button quitButton;
    public GameObject exitFontPanel;
    public string Endless;
    public string Timed;

    public TextMeshProUGUI licenseText;
    public string[] licenseSections;
    public int licenseSection = 0;
    public GameObject scrollDown;
    public GameObject scrollUp;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0) SceneManager.LoadScene(Endless);
        if (slider.value == 2) SceneManager.LoadScene(Timed);
    }

    public void LicenseOpen()
    {
        exitFontPanel.SetActive(true);
        fontButton.interactable = false;
        quitButton.interactable = false;
    }
    public void LicenseClose()
    {
        exitFontPanel.SetActive(false);
        fontButton.interactable = true;
        quitButton.interactable = true;
    }
    public void ScrollUp()
    {
        licenseSection--;
        licenseText.text = licenseSections[licenseSection];
        scrollDown.SetActive(true);
        if (licenseSection == 0) scrollUp.SetActive(false);
    }
    public void ScrollDown()
    {
        licenseSection++;
        Debug.Log(licenseSection);
        licenseText.text = licenseSections[licenseSection];
        scrollUp.SetActive(true);
        if (licenseSection == 4) scrollDown.SetActive(false);

    }
    public void QuitApp()
    {
        Application.Quit();
    }

}

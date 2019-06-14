using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LabManagerTitrasi : MonoBehaviour
{

    public GameObject PanelFokus;
    public GameObject PanelPerintah;
    public GameObject PanelPetunjuk;
    public GameObject PanelApparatus;
    //PERCOBAAN1
    public GameObject Buret;
    public GameObject Erlenmeyer;
    public GameObject Pipet;
    public GameObject tetesButton;

    private int ppTetesCount = 0;

    public Button ButtonSlideIn;
    public Sprite ButtonImageIn;
    public Sprite ButtonImageOut;
    private Animator AnimatorPanelApparatus;

    public bool SlideIn;

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        Buret = GameObject.Find("Canvas/Panel/Buret");
        SlideIn = true;
        AnimatorPanelApparatus = PanelApparatus.GetComponent<Animator>();
        Screen.orientation = ScreenOrientation.Landscape;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")) SceneManager.LoadScene(0);

        if(Buret != null)
        {
            if (Buret.activeInHierarchy && Erlenmeyer.activeInHierarchy && ppTetesCount >= 3)
            {
                tetesButton.SetActive(true);
                Pipet.SetActive(false);
            }
        }
    }



    public void ButtonPerintah()
    {
        PanelFokus.SetActive(true);
        PanelPerintah.SetActive(true);
    }

    public void ButtonPetunjuk()
    {
        PanelFokus.SetActive(true);
        PanelPetunjuk.SetActive(true);
    }

    public void ButtonHome()
    {
        SceneManager.LoadScene("sceneMain");
    }

    public void ButtonApparatusTray()
    {
        if (SlideIn == false)
        {
            AnimatorPanelApparatus.SetBool("SlidedIn", true);
            ButtonSlideIn.GetComponent<Image>().sprite = ButtonImageIn;
            SlideIn = true;
        }
        else
        {
            AnimatorPanelApparatus.SetBool("SlidedIn", false);
            ButtonSlideIn.GetComponent<Image>().sprite = ButtonImageOut;
            SlideIn = false;
        }

    }

    public void ClosePanelFokus()
    {
        PanelPerintah.SetActive(false);
        PanelPetunjuk.SetActive(false);
        PanelFokus.SetActive(false);
    }

    public void AddBuret()
    {
        Buret.SetActive(true);
        GameObject.Find("ButtonBuret").SetActive(false);
    }

    public void AddErlenmeyer()
    {
        Erlenmeyer.SetActive(true);
        GameObject.Find("ButtonErlenmeyer").SetActive(false);
    }

    public void ButtonPipet()
    {
        ppTetesCount++;
        if (ppTetesCount >= 3) Pipet.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LabManagerElektrolit : MonoBehaviour
{

    public GameObject PanelFokus;
    public GameObject PanelPerintah;
    public GameObject PanelPetunjuk;
    public GameObject PanelApparatus;
    //PERCOBAAN2
    public GameObject GelasUkur;
    public GameObject Larutan;
    public GameObject CapitHitam;
    public GameObject CapitMerah;
    public GameObject ParticleBubbles;
    public GameObject LampuNyala;
    public GameObject LampuMati;
    public Dropdown OpsiLarutan;
    public int dropdownValue;
    public Image ImageLarutan;
    private Color TempColor;

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
        SlideIn = true;
        AnimatorPanelApparatus = PanelApparatus.GetComponent<Animator>();
        Screen.orientation = ScreenOrientation.Landscape;
        ImageLarutan = Larutan.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        dropdownValue = OpsiLarutan.value;

        if (Input.GetKeyDown("escape")) SceneManager.LoadScene(0);
        

        if(dropdownValue == 0) //NIPIS
        {
            ImageLarutan.color = new Color(247, 255, 66, 0.57f);
            if (GelasUkur.activeInHierarchy && CapitHitam.activeInHierarchy && CapitMerah.activeInHierarchy) LampuNyala.SetActive(true);
            if (CapitHitam.activeInHierarchy && CapitMerah.activeInHierarchy)  ParticleBubbles.SetActive(true);
        }
        else if (dropdownValue == 1 || dropdownValue == 2 || dropdownValue == 4)
        {
            ImageLarutan.color = new Color(66, 255, 255,0.57f);
            LampuMati.SetActive(false);
            if (GelasUkur.activeInHierarchy && CapitHitam.activeInHierarchy && CapitMerah.activeInHierarchy) LampuNyala.SetActive(true);
            if (CapitHitam.activeInHierarchy && CapitMerah.activeInHierarchy) ParticleBubbles.SetActive(true);
        }
        else if (dropdownValue == 5)
        {
            ImageLarutan.color = new Color(91, 190, 186, 0.57f);
            LampuMati.SetActive(true);
            LampuNyala.SetActive(false);
            ParticleBubbles.SetActive(false);
        }
        else if (dropdownValue == 3)
        {
            ImageLarutan.color = new Color(91, 190, 186, 0.57f);
            LampuMati.SetActive(true);
            LampuNyala.SetActive(false);
            ParticleBubbles.SetActive(false);
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

    public void AddGelasUkur()
    {
        GelasUkur.SetActive(true);
        GameObject.Find("ButtonGelas").SetActive(false);
    }

    public void AddCapitHitam()
    {
        CapitHitam.SetActive(true);
        GameObject.Find("ButtonCapitHitam").SetActive(false);
    }

    public void AddCapitMerah()
    {
        CapitMerah.SetActive(true);
        GameObject.Find("ButtonCapitMerah").SetActive(false);
    }

}

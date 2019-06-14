using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LabManagerKalorimeter : MonoBehaviour
{

    public GameObject PanelFokus;
    public GameObject PanelPerintah;
    public GameObject PanelPetunjuk;
    public GameObject PanelApparatus;

    public GameObject Kalorimeter;
    public GameObject GelasTuang1;
    public GameObject GelasTuang2;
    public GameObject Termometer;
    public GameObject Adukan;

    public Text TextSuhu;

    private float Suhu = 21.0f;
    private int jumlahLarutan = 0;
    private int counter = 0;

    public Button ButtonAduk;
    public Button ButtonSlideIn;
    public Sprite ButtonImageIn;
    public Sprite ButtonImageOut;
    public Sprite MixStart;
    public Sprite MixStop;
    private Animator AnimatorPanelApparatus;

    public bool SlideIn;
    public bool IsMixing = true;

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        SlideIn = true;
        AnimatorPanelApparatus = PanelApparatus.GetComponent<Animator>();
        Screen.orientation = ScreenOrientation.Landscape;
        GameObject.Find("ButtonNaOH").GetComponent<Button>().interactable = false;
        GameObject.Find("ButtonHCl").GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsMixing && counter < 360)
        {
            Suhu += 0.01f * Time.deltaTime;
            counter++;
        }
        TextSuhu.text = Suhu.ToString("F");

        if (jumlahLarutan >= 2) ButtonAduk.gameObject.SetActive(true);
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

    public void AddKalorimeter()
    {
        Kalorimeter.SetActive(true);
        GameObject.Find("ButtonKalorimeter").SetActive(false);
        GameObject.Find("ButtonNaOH").GetComponent<Button>().interactable = true;
        GameObject.Find("ButtonHCl").GetComponent<Button>().interactable = true;
    }

    public void AddTermometer()
    {
        Termometer.SetActive(true);
        GameObject.Find("ButtonTermometer").SetActive(false);
    }

    public void AddHCl()
    {
        GelasTuang1.SetActive(true);
        GameObject.Find("ButtonHCl").SetActive(false);
        jumlahLarutan++;
    }

    public void AddNaOH()
    {
        GelasTuang2.SetActive(true);
        GameObject.Find("ButtonNaOH").SetActive(false);
        jumlahLarutan++;
    }

    public void ButtonMix()
    {
        if (!IsMixing)
        {
            Adukan.SetActive(true);
            ButtonAduk.GetComponent<Image>().sprite = MixStop;
            IsMixing = true;
        }
        else 
        {
            Adukan.SetActive(false);
            ButtonAduk.GetComponent<Image>().sprite = MixStart;
            IsMixing = false;
        }
    }

}

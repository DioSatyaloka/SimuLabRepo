using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TetesBuret : MonoBehaviour
{
    public GameObject Erlenmeyer;
    public GameObject Buret;
    public Image imageBuret;
    public Image imageErlenmeyer;
    public Text textVolBuret;
    public float volBuret = 30.0f;
    private bool isTetes = false;

    // Start is called before the first frame update
    void Start()
    {
        imageErlenmeyer = Erlenmeyer.GetComponent<Image>();
        imageBuret = Buret.GetComponent<Image>();
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        var tempcolor = imageErlenmeyer.color;

        if (isTetes && volBuret >= 0)
        {
            volBuret -= 0.01f;
            if(tempcolor.a <= 0.6f)
            {
                tempcolor.a += 0.003f;
                imageErlenmeyer.color = tempcolor;
            }
            textVolBuret.text = volBuret.ToString("F");
        }
    }

    public void ButtonTetes()
    {
        isTetes = !isTetes;
    }

}

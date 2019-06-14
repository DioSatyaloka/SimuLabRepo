using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class penjelasanElektrolit : MonoBehaviour {

    public void elektrolitKuat()
    {
        SceneManager.LoadScene("scenePenjelasanSubElektrolitKuat");
    }
    public void elektrolitLemah()
    {
        SceneManager.LoadScene("scenePenjelasanSubElektrolitLemah");
    }
    public void nonElektrolit()
    {
        SceneManager.LoadScene("scenePenjelasanSubNonElektrolit");
    }
}

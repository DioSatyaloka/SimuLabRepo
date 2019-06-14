using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class penjelasanTitrasi : MonoBehaviour {

    public void asamKuatBasaKuat()
    {
        SceneManager.LoadScene("scenePenjelasanSubAsamKuatBasaKuat");
    }
    public void asamLemahBasaKuat()
    {
        SceneManager.LoadScene("scenePenjelasanSubAsamLemahBasaKuat");
    }
    public void asamKuatBasaLemah()
    {
        SceneManager.LoadScene("scenePenjelasanSubAsamKuatBasaLemah");
    }
    public void rumusTitrasi()
    {
        SceneManager.LoadScene("scenePenjelasanSubRumusTitrasi");
    }
}

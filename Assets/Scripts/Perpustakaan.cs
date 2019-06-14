using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perpustakaan : MonoBehaviour
{
    public void titrasiAsam()
    {
        SceneManager.LoadScene("scenePerpustakaanPenjelasanTitrasi");
    }
    public void termoKimia()
    {
        SceneManager.LoadScene("scenePerpustakaanPenjelasanTermokimia");
    }
    public void larutanElektrolit()
    {
        SceneManager.LoadScene("scenePerpustakaanPenjelasanElektrolit");
    }
}

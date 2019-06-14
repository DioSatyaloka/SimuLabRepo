using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
   public void perpustakaan()
   {
        SceneManager.LoadScene("scenePerpustakaanList");
   }
   public void praktikum()
   {
        SceneManager.LoadScene("LabMenu");
   }
   public void soal()
   {

   }
}

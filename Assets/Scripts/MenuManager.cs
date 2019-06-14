using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonLabElektrolit()
    {
        SceneManager.LoadScene("LabSceneElektrolit");
    }

    public void ButtonLabTermokimia()
    {
        SceneManager.LoadScene("LabSceneTermokimia");
    }

    public void ButtonLabTitrasi()
    {
        SceneManager.LoadScene("LabSceneTitrasi");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    uint tapCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            tapCount++;
            if (!IsInvoking("disableDoubleClick"))
                Invoke("disableDoubleClick", 0.3f);
        }
        if (tapCount == 2)
        {
            CancelInvoke("disableDoubleClick");
            Application.Quit();
        }
    }

    void disableDoubleClick()
    {
        tapCount = 0;
    }
}

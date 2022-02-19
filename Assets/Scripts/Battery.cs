using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public float battery = 20;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GetComponent<Light>().enabled == false)
            {
                if (battery > 0)
                {
                    GetComponent<Light>().enabled = true;
                }
            }

            else

            {
                GetComponent<Light>().enabled = false;
            }
        }
    }
}

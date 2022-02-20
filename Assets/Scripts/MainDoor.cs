using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{
    public GameObject mainDoor;
    public GameObject key;

    void Update()
    {
        if (key == false)
            mainDoor.SetActive(true);
    }
}

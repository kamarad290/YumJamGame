using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public string sceneToLoad;
    public string exitName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerPrefs.SetString("LastExitName", exitName);
            Debug.Log("Scene changed to " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

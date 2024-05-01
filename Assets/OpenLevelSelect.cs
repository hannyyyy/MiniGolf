using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelSelect : MonoBehaviour
{
    public void OpenLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

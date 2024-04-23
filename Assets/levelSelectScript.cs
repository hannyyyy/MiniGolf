using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenLevel(int levelId)
    {
        string levelName = "Level " + (levelId + 1);
        SceneManager.LoadScene(levelName);
    }
}

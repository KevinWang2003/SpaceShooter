using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadSingleGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMultiGame()
    {
        SceneManager.LoadScene(2);
    }
}

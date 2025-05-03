using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver;

    [SerializeField]
    private bool _isGamePaused;
    [SerializeField]
    private GameObject _pausePanel;

    private Animator _PauseAnimator;

    //public bool isCoopMode = false;

    private void Start()
    {
        _PauseAnimator = GameObject.Find("Pause_Menu").GetComponent<Animator>();
        _PauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver == true)
        {
            //if (isCoopMode)
            //{
            //    SceneManager.LoadScene(2); // CO-OP
            //}
            SceneManager.LoadScene(1); // Single Player
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    private void PauseMenu()
    {
        if (_isGamePaused)
        {
            Unpause();
        }
        else
        {
            _isGamePaused = true;
            _pausePanel.SetActive(true);
            _PauseAnimator.SetBool("isPaused", true);
            Time.timeScale = 0;
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
    }

    public void Unpause()
    {
        _isGamePaused = false;
        _pausePanel.SetActive(false);
        _PauseAnimator.SetBool("isPaused", false);
        Time.timeScale = 1;
    }

    public void ReturnToMainMenus()
    {
        Unpause();
        SceneManager.LoadScene(0);
    }

    //public void IsCoopMode()
    //{
    //    isCoopMode = true;
    //}
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject PauseMenu; 

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResumeGame()
    {
        if (PauseMenu != null)
            PauseMenu.SetActive(false);
        else
            Debug.Log("Resume pressed (no pauseMenu assigned)");
    }
}

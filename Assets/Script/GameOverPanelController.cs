using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelController : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    public void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void ContinueButtonClicked()
    {
        // Load "Car" scene or whatever your car scene is called
        SceneManager.LoadScene("car");
    }

    public void ExitButtonClicked()
    {
        // Load "StartScene" or your starting panel scene
        SceneManager.LoadScene("Panel");
    }
}

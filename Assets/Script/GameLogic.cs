using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject gameOverPanel;
    public GameObject victoryPanel;

    void Update()
    {
        if (AllCarsDestroyed())
        {
            Victory();
        }

        if (PlayerDead())
        {
            GameOver();
        }
    }

    bool AllCarsDestroyed()
    {
        GameObject[] cars = GameObject.FindGameObjectsWithTag("car");
        return cars.Length == 0;
    }

    bool PlayerDead()
    {
        // Implement player death logic
        // For example, check if player health is less than or equal to zero
        return false;
    }

    void Victory()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }

        SceneManager.LoadScene("GameWin");
    }

    void GameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        SceneManager.LoadScene("GameOver");
    }
}

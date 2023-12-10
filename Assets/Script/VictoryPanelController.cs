using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPanelController : MonoBehaviour
{
    public GameObject victoryPanel;

    void Start()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(false);
        }
    }

    public void ShowVictoryPanel()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }
    }

    public void ContinueButtonClicked()
    {
        // Load "Car" scene or whatever your car scene is called
        SceneManager.LoadScene("Panel");
    }
}

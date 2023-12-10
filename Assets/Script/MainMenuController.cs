// MainMenuController.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject startPanel;
    public GameManager gameManager;

    void Start()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(true);
        }
    }

    public void PlayButtonClicked()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(false);
        }

        SceneManager.LoadScene("car");
        Time.timeScale = 1f;
    }

    // 新添加的方法，在得到40分时调用
    public void ShowStartPanel()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(true);
        }
    }
}

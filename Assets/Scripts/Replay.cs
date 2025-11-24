using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour
{
    public Button restartButton;

    private void Start()
    {
        if (restartButton == null) return;

        // Buton görünür başlar
        restartButton.gameObject.SetActive(true);

        // Click listener
        restartButton.onClick.RemoveAllListeners();
        restartButton.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        PlayerInfo.can = 3;
        SceneManager.LoadScene(1); // İlk sahneye dön
                                   // Canı resetle
    }


}

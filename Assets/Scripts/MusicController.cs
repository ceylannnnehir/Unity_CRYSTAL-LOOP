using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;
    public Button muteButton;
    public Sprite speakerOnSprite;
    public Sprite speakerOffSprite;
    private bool isMuted = false;

    private Image buttonImage;

    void Start()
    {
        // Butonun kendi Image bileşenini al
        buttonImage = muteButton.GetComponent<Image>();

        muteButton.onClick.AddListener(ToggleMute);

        UpdateButtonVisual();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;

        if (musicSource != null)
        {
            if (isMuted) musicSource.Pause();
            else musicSource.Play();
        }

        UpdateButtonVisual();
    }

    private void UpdateButtonVisual()
    {
        if (buttonImage != null)
        {
            buttonImage.sprite = isMuted ? speakerOffSprite : speakerOnSprite;
        }
    }
}

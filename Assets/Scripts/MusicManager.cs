using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;

    private AudioSource audioSource;
    private bool isMuted = false;

    // Optional UI reference (kullanırken inspector'a bağla)
    [SerializeField] private Button muteButton;

    private void Awake()
    {
        // Köke taşı: eğer parent varsa null yap
        if (transform.parent != null)
        {
            transform.SetParent(null);
            Debug.Log("Moved MusicManager to root (no parent).");
        }

        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // AudioSource hazırla
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        // Varsayılan başlatma
        if (audioSource.clip != null && !isMuted)
        {
            audioSource.loop = true;
            audioSource.Play();
        }

        // UI ile bağlantı (varsa)
        if (muteButton != null)
        {
            muteButton.onClick.AddListener(ToggleMute);
        }
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        if (audioSource != null)
        {
            audioSource.mute = isMuted;
        }

        // UI durumunu güncelle (library-a bağlı olarak)
        if (muteButton != null)
        {
            // Örnek: metin değiştirme veya ikon güncelle
        }
    }
}
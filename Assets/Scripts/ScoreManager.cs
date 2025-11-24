using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;                  // Toplam skor
    private int sceneStartScore = 0;       // Sahneye girildiğinde skor neydi
    private string lastSceneName = "";     // Son sahne adı
    private string mainSceneName = "1-IlkSahne"; // Oyunun başlangıç sahnesi 

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StartCoroutine(FindScoreTextDelayed());

        if (scene.name == mainSceneName)
        {
            // Oyun baştan başladı
            ResetScore();
            sceneStartScore = 0;
            Debug.Log("[ScoreManager] Ana sahneye dönüldü, skor sıfırlandı.");
        }
        else if (scene.name == lastSceneName)
        {
            // Aynı sahne yeniden yüklendiyse (ölüm sonrası restart)
            score = sceneStartScore; // O sahneye girildiğindeki skora dön
            Debug.Log($"[ScoreManager] Aynı sahne yeniden yüklendi. Skor {score} olarak geri yüklendi.");
        }
        else
        {
            // Yeni sahneye geçildi
            sceneStartScore = score; // Bu sahnenin başlangıç skorunu kaydet
            Debug.Log($"[ScoreManager] Yeni sahneye geçildi. Başlangıç skoru: {sceneStartScore}");
        }

        lastSceneName = scene.name;
        UpdateScoreText();
    }

    private IEnumerator FindScoreTextDelayed()
    {
        yield return null; // 1 frame bekle
        var foundText = GameObject.Find("ScoreText");
        if (foundText != null)
        {
            scoreText = foundText.GetComponent<TextMeshProUGUI>();
            UpdateScoreText();
        }
        else
        {
            Debug.LogWarning("[ScoreManager] ScoreText bulunamadı!");
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        Debug.Log($"[ScoreManager] +{amount} eklendi, yeni skor: {score}");
    }

    // 🔻 Oyuncu öldüğünde çağrılacak
    public void OnPlayerDied()
    {
        int sceneScore = score - sceneStartScore; // O sahnede kazanılan fark
        score -= sceneScore; // O sahnede kazanılan kadar puanı geri al
        if (score < 0) score = 0; // negatif olmasın

        Debug.Log($"[ScoreManager] Oyuncu öldü! Bu sahnede {sceneScore} puan kazanmıştı, skor {score} oldu.");
        UpdateScoreText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

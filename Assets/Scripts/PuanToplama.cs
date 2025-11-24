using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuanToplama : MonoBehaviour
{
    //[SerializeField] int Score = 0;
    //[SerializeField] TextMeshProUGUI Score_Text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Elmas"))
        {
            AudioSource ses = collision.GetComponent<AudioSource>(); // Elmasın sesini al
            if (ses != null)
            {
                ses.Play(); // Sesi çal
            }

            Destroy(collision.gameObject, 0.3f); // Ses çalınsın diye biraz gecikmeli sil

            // Puan ekle
            if (ScoreManager.Instance != null)
                ScoreManager.Instance.AddScore(1);
            //Score++;
            //Score_Text.text = "Score:"+ Score.ToString();
        }
    }
}

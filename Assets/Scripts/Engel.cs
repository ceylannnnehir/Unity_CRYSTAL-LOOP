using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 
/// kullandığımız sahneyi çağırmak için yani sahneleri kontrol etmek...

public class Engel : MonoBehaviour
{
    public int Index;
    private Scene _scene; // aktif sahne değişkeni index ile belirleme
    [SerializeField] TextMeshProUGUI Oyuncucan;

    private void Awake() //mevcut sahneyi belirleme...
    {
        _scene = SceneManager.GetActiveScene(); // aktif sahneyi alıp yeni oluşturulan sahneyi değişkene atar
        Oyuncucan.text = " Heart: "+ PlayerInfo.can.ToString();   
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player")) // oyuncu engele çarpıyorsa sahneyi baştan yükle
        {
            //SceneManager.LoadScene(Index); // sahne numarası ayarlanama
            PlayerInfo.can--; // can değerini azalt
            SceneManager.LoadScene(_scene.buildIndex); //aktif sahneyi cağır
        }

        if(PlayerInfo.can == 0)
        {
            SceneManager.LoadScene(Index);
        }
    }

}

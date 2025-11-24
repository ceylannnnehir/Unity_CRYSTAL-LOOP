using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    Scene scene;
    public int sceneIndex;

    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }

    // sahne geçişlerinde kullandığım kod...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
        
    }

    // Oyun sonu ve oyunu ilk başlattığımda kullandığım kodum..
    public void NextLvl()
    {
        // sahnede verdiğim index değerleri sahneyi yükle
        SceneManager.LoadScene(sceneIndex);
        //  oyunu ilk başlattığımda var sayarak can 3 olması..
        PlayerInfo.can = 3;
    }
}

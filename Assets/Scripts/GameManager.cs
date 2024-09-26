using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        // Singleton deseni: tek bir GameManager �rne�i oldu�undan emin olun
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Oyun sahneleri aras�nda bu nesnenin yok olmamas�n� sa�lar
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        // AnaMen� sahnesini y�kleyin
        SceneManager.LoadScene("GameOver");
    }
}

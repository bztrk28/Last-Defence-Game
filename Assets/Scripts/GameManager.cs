using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        // Singleton deseni: tek bir GameManager örneði olduðundan emin olun
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Oyun sahneleri arasýnda bu nesnenin yok olmamasýný saðlar
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        // AnaMenü sahnesini yükleyin
        SceneManager.LoadScene("GameOver");
    }
}

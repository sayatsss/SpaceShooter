using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject HUD;
    [SerializeField] private GameObject Menu;

    [HideInInspector] public string gameState;
    private void Start()
    {
        gameState = "Menu";
        HUD.SetActive(false);
        gameOverUI.SetActive(false);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if(Score.instance.playerLife<1)
        {
            gameOverUI.SetActive(true);
            HUD.SetActive(false);
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadSceneAsync(0);
            }
        }
        
    }
    public void GameStart()
    {
        Menu.SetActive(false);
        HUD.SetActive(true);
        Time.timeScale = 1;
    }
}

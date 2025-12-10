using UnityEngine;

public class PauseManager : MonoBehaviour
{
   [SerializeField]

   private GameObject pauseMenu;

   public void Start()
    {
        ResumeGame();
    }

   public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

    }


}

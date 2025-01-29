using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance

    // Events for game states
    public UnityEvent OnLevelStart = new UnityEvent();
    public UnityEvent OnLevelWin = new UnityEvent();
    public UnityEvent OnLevelLose = new UnityEvent();

    private void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }

    // Call this method to start a level
    public void StartLevel()
    {
        OnLevelStart.Invoke();
    }

    // Call this when the player wins
    public void WinLevel()
    {
        OnLevelWin.Invoke();
    }

    // Call this when the player loses
    public void LoseLevel()
    {
        OnLevelLose.Invoke();
    }
}
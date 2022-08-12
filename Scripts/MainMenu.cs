using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public string level1;
     public GameObject how;
    [SerializeField] private string gameScene;

public void StartGame()
{
    SceneManager.LoadScene(level1);
}
public void PlayGame()
{
    SceneManager.LoadScene(gameScene);
}

public void QuitGame()
{
    Application.Quit();
}

public void Openhow()
{
    how.SetActive(true);
}

public void Closehow()
{
    how.SetActive(false);
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

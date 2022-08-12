using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timer;
    
    public bool timestart ;
    public float timeAmount = 10.1f;
    
    // Update is called once per frame
    void Update()
    {
        timer.fillAmount -=1.0f / timeAmount * Time.deltaTime;
        
         if( timeAmount <= 0)
        {
         SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }
    }

}

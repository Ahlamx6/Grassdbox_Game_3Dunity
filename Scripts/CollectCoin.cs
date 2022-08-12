using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI collectcoins;

    private PlayerJump playerJumpScript;
    private int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        playerJumpScript = GetComponent<PlayerJump>();
    }

    void Update()
    {
        collectcoins.text = ("" + coins);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
        coins ++;
        //playerJumpScript.sm.PlayCoinCollect();
        Destroy(other.gameObject);
        }
    

        if (other.gameObject.CompareTag("winner") && coins >= 10)
        {
            Debug.Log("winner");
            playerJumpScript.sm.PlayWinSound();
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }

        if (other.gameObject.CompareTag("winner") && coins < 10)
        {
            Debug.Log("collect more coins");

        }
    }
}

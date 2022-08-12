using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private float healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = healthAmount;
    }

    private void OnCollisionEnter(Collision collision )
    {

        if(collision.gameObject.CompareTag("Enemy"))
        {
            healthAmount -= 0.9f * Time.deltaTime;
        }
    }
}

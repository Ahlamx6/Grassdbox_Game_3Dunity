using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHealth : MonoBehaviour
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

        if(Input.GetButton("Fire1"))
        healthAmount -= 0.5f * Time.deltaTime;

        else if(Input.GetButton("Fire2"))
        healthAmount += 0.5f * Time.deltaTime;
    }
}

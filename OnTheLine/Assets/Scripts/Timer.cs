using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject oyuncu;
    public GameObject timer;
    
    public float startingTime;
    private Text theText;
    void Start()
    {
        theText = GetComponent<Text>();
    }

    
    void Update()
    {
        if (gameOverPanel.active)
        {
            return;
        }
        startingTime -= Time.deltaTime;
        if(startingTime < 0)
        {
            OyunSonu();
        }
        theText.text = "" + Mathf.Round(startingTime);
    }
    void OyunSonu()
    {
        gameOverPanel.SetActive(true);
        oyuncu.SetActive(false);
        timer.SetActive(false);

        




    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player3 : MonoBehaviour
{
    public float hiz;
    public GameObject gameOverPanel;
    public GameObject oyuncu;
    public GameObject timer;
    Rigidbody2D agirlik;
    public AudioSource soundEffect;
    public AudioSource successEffect;

    void Start()
    {

        agirlik = GetComponent<Rigidbody2D>();
        gameOverPanel.SetActive(false);

    }

    bool isPicked;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("SingleMaps");
        }
        if (Input.GetMouseButtonUp(0))
        {
            isPicked = false;
        }
        if (isPicked == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;

        }
    }
    void OnMouseDown()
    {
        isPicked = true;
    }


    void OnCollisionEnter2D(Collision2D cisim)
    {
        if (cisim.gameObject.name == "upside")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "1")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "2")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "3")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "4")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "5")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "6")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "7")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "8")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "yol1")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "yol2")
        {
            soundEffect.Play();
            OyunSonu();
        }
        if (cisim.gameObject.name == "downside")
        {
            successEffect.Play();
            Debug.Log("TEBRİKLER!BÖLÜMÜ BAŞARIYLA TAMAMLADINIZ.");
            if (Application.loadedLevelName == "3")
            {
                PlayerPrefs.SetInt("4", 1);
                Application.LoadLevel("4");
            }
        }
    }
    void OyunSonu()
    {
        gameOverPanel.SetActive(true);
        oyuncu.SetActive(false);
        timer.SetActive(false);

    }
    


}

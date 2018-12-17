using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    
    public GameObject oyuncu;
    Rigidbody2D agirlik;
	void Start () {
        
        agirlik = GetComponent<Rigidbody2D>();
        
          
	}

    bool isPicked;
    void Update () {
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
    
}

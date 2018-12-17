using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SinglePlayer()
    {
        Application.LoadLevel("SingleMaps");
    }
    public void MultiPlayer()
    {
        Application.LoadLevel("Lobby");
    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}

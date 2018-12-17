using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DestroyObject(gameObject);
            Application.LoadLevel("MainMenuLive");

        }
    }
}

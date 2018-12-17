using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        Application.LoadLevel("SingleMaps");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
    public void multiplayerLobby ()
    {
        Application.LoadLevel("LobbyReal");
    }
    public void backToMenu()
    {
        Application.LoadLevel("MainMenuLive");
    }

}

using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class PauseMenu : NetworkBehaviour
{

    public static bool IsOn = false;

    private NetworkManager networkManager;

    void Start()
    {
        networkManager = NetworkManager.singleton;
    }

    public void LeaveRoom()
    {

        Application.Quit();
        /*MatchInfo matchInfo = networkManager.matchInfo;
        networkManager.matchMaker.DropConnection(matchInfo.networkId, matchInfo.nodeId, 0, networkManager.OnDropConnection);
        networkManager.StopHost(); */
    }

    public void backToMenux()
    {
       /*System.Diagnostics.Process.Start(Application.dataPath.Replace("_Data", ".exe"));
        Application.Quit();*/
        Application.LoadLevel("MainMenuLive");       
    }

    public void playAgainButton()
    {
        Application.LoadLevel("LobbyReal");
    }

}

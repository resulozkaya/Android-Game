using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DestroyerNLB : MonoBehaviour {

    void Start()
    {
        Destroy(GameObject.Find("LobbyManager"));
        NetworkServer.Reset();
    }

}

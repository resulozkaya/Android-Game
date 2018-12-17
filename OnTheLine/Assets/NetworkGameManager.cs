using UnityEngine;
using UnityEngine.Networking;
using Prototype.NetworkLobby;
using System.Collections;
using System.Collections.Generic;
using System;

public class NetworkGameManager : NetworkBehaviour {

    static public List<Silinebilir> sPlyrs = new List<Silinebilir>();
    static public NetworkManager sInstance = null;

    [Header("Gameplay")]

    public GameObject[] plyrPrefabs;

    [Space]

    protected bool _spawningPlyr = true;
    protected bool _running = true;

    void Awake()
    {
        
    }

    void Start () {
		
	}
	
	[ServerCallback]
	void Update () {
		if(!_running || sPlyrs.Count ==0)
        {
            return;
        }
        
	}

   
}

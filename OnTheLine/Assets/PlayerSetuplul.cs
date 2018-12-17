
using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetuplul : NetworkBehaviour {

    [SerializeField]
    Behaviour[] componentsToDisable;

    [SerializeField]
    string remoteLayerName = "RemotePlayer";

	void Start () {
        if(!isLocalPlayer)
        {
            DisableComponents();
            AssignRemoteLayer();
        }

        RegisterPlayer();
		
	}

    void RegisterPlayer()
    {
        string _ID = "Player" + GetComponent<NetworkIdentity>().netId;
        transform.name = _ID;
    }

    void AssignRemoteLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(remoteLayerName);
    }
    void DisableComponents()
    {
        for (int i = 0; i < componentsToDisable.Length; i++)
        {
            componentsToDisable[i].enabled = false;
        }

    }
	
	
}

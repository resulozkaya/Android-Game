using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using Prototype.NetworkLobby;

public class Silinebilir : NetworkBehaviour
{
    public Sprite mySprite;
    public float hiz;
    public GameObject oyuncu;
    Rigidbody2D agirlik;
    [SerializeField]
    GameObject pauseMenu;
    [SerializeField]
    GameObject pauseMenu2;
    [SerializeField]
    GameObject player;

    Collider2D PC;

    public NetworkStartPosition[] spawnPoints;

    void Awake()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        NetworkGameManager.sPlyrs.Add(this);
    }

    void Start()
    {
        

        if (isLocalPlayer)
        {
            spawnPoints = FindObjectsOfType<NetworkStartPosition>();
        }

        agirlik = GetComponent<Rigidbody2D>();
        PauseMenu.IsOn = false;
        
    }

 
    bool isPicked;

    void OnDestroy()
    {
        NetworkGameManager.sPlyrs.Remove(this);
    }

    [ClientCallback]
    void Update()
    {

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
    void TogglePauseMenu ()
    {
        if(isLocalPlayer)
            pauseMenu.SetActive(true);
        else
            pauseMenu2.SetActive(true);

        PauseMenu.IsOn = true;
       

    }

    void TogglePauseMenu2()
    {
        pauseMenu2.SetActive(!pauseMenu2.activeSelf);
        PauseMenu.IsOn = pauseMenu2.activeSelf;


    }
    void OnMouseDown()
    {
        isPicked = true;
    }

    [ClientCallback]
    void OnCollisionEnter2D(Collision2D cisim)
    {
        if(cisim.gameObject.name=="finishLine")
        {
            
            StartCoroutine(ReturnToLoby());
            //TogglePauseMenu();
        }
        else
        {
            //True();
            if (isServer)
            {

                RpcRespawn();
            }
            else
            {
                if (hasAuthority)
                    CmdResul();
            }
        }
  
    }
    public override void OnStartLocalPlayer()
    {
        this.GetComponent<SpriteRenderer>().sprite = mySprite;
        Camera.main.GetComponent<CamFollow>().setTarget(player);
    }

    [ClientRpc]
    void RpcRespawn()
    {
        isPicked = false;
        if(isServer)
        {
            float yy = transform.position.y;

            yy = ((int)(yy / 10)) * 10;         // 10 rakamı ayarlanabilir

            Vector3 v = spawnPoints[0].transform.position;
            v.y = yy;
            transform.position = v;
        }
        else
        {
            float yy = transform.position.y;

            yy = ((int)(yy / 10)) * 10;

            Vector3 v = spawnPoints[1].transform.position;
            v.y = yy;
            transform.position = v;
        }

      
    }
    [Command]
    public void CmdResul()
    {
        RpcRespawn();
    }
    public void True()
    {
        Collider2D PC = GetComponent<Collider2D>();
        PC.isTrigger = true;
    }
    public void False()
    {
        Collider2D PC = GetComponent<Collider2D>();
        PC.isTrigger = false;
    }
    IEnumerator ReturnToLoby()
    {
        TogglePauseMenu();
        yield return new WaitForSeconds(3.0f);
        LobbyManager.s_Singleton.ServerReturnToLobby();
    }
   
}


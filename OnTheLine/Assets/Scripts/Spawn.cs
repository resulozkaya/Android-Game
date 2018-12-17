using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPointX;

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnPointX.transform.position;
    }
}

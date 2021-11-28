using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public static Player instance;

    public Transform player;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        player = transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.EndGame();
    }
}

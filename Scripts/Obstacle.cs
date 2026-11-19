using System.Collections;
using System.Collections.Generic;
using Mainframe.Scripts.Game;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void FixedUpdate()
    {
        if (!Game.IsInMicrogame())
            return;
        
        Vector2 pos = transform.position;

        pos.x -= player.velocity.x * Time.fixedDeltaTime;
        if (pos.x < -100)
        {
            Destroy(gameObject);
        }

        transform.position = pos;
    }
}
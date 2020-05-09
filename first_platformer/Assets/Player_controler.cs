using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public Rigidbody2D player;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = new Vector2(-5, player.velocity.y);
            //TODO: find a way to change the animation with movement
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(5, player.velocity.y);
            //TODO: change animation
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            player.velocity = new Vector2(player.velocity.x, 5);
        }
    }
}

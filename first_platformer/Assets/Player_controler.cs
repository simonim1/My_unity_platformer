using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public Rigidbody2D player;
    int jump_thresh_hold = 0;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = new Vector2(-5, player.velocity.y);
            jump_thresh_hold = 0;
            //TODO: find a way to change the animation with movement
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(5, player.velocity.y);
            jump_thresh_hold = 0;
            //TODO: change animation

        }
        if(Input.GetKey(KeyCode.UpArrow) && jump_thresh_hold<2)
        {

            //Need to figure out how to limit the up arrow count. 
            //if user holds the up arrow the character is flying
            player.velocity = new Vector2(player.velocity.x, 10f);
            jump_thresh_hold += 1;
        }
    }
}

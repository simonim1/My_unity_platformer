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
            player.velocity = new Vector2(-2, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(2, 0);
        }
    }
}

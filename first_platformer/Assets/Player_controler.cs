using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public Rigidbody2D player; 
    public Animator anim;

    private int jump_thresh_hold = 0;
    private string running_anim_param = "running";
  

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = new Vector2(-5, player.velocity.y);
            jump_thresh_hold = 0;
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool(running_anim_param, true);
           
        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = new Vector2(5, player.velocity.y);
            jump_thresh_hold = 0;
            transform.localScale = new Vector2(1, 1);
            anim.SetBool(running_anim_param, true);

        }else if(Input.GetKey(KeyCode.UpArrow) && jump_thresh_hold<=2)
        {
            
            player.velocity = new Vector2(player.velocity.x, 6f);
            jump_thresh_hold += 1;
        }
        else
        {
            anim.SetBool(running_anim_param, false);
        }
        //default idel 

    }
}

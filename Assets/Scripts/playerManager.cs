using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    private bool jump;
    public float speed, jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");

        player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
        if (jump == true)
        {
            player.AddForce(new Vector2(0, jumpForce));
        }
    }
}

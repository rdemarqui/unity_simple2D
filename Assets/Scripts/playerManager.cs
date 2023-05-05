using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed, jumpForce, alturaCamera;
    private bool jump, isgrounded;
    private GameObject cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        cameraPos = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
        cameraPos.transform.position = new Vector3(cameraPos.transform.position.x,
            player.transform.position.y + alturaCamera, cameraPos.transform.position.z);
        player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
        
        if (jump == true && isgrounded == true)
        {
            player.AddForce(new Vector2(0, jumpForce));
            isgrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 8)
        {
            isgrounded = true;
        }
    }
}

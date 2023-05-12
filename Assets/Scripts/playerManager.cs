using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed, jumpForce, alturaCamera, speedWin;
    private bool jump, isgrounded, restartPlayer, win;
    private GameObject cameraPos, inicialPos;
    public GameObject panelWin;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        cameraPos = GameObject.Find("Main Camera");
        inicialPos = GameObject.Find("inicialPos");
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(win);
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
        Restart();
        WinGame();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 8)
        {
            isgrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("armadilhas") == true)
        {
            restartPlayer = true;
        }
        if (col.CompareTag("win") == true)
        {
            win = true;
        }
    }
    private void Restart()
    {
        if (restartPlayer == true)
        {
            player.transform.position = new Vector2(inicialPos.transform.position.x, inicialPos.transform.position.y);
            restartPlayer = false;
        }
    }
    private void WinGame()
    {
        if (win == true)
        {
            colectCoins.save = true;
            player.velocity = new Vector2(0, player.velocity.y);
            panelWin.transform.position = Vector2.MoveTowards(panelWin.transform.position, cameraPos.transform.position, speedWin * Time.deltaTime);
        }
    }
}

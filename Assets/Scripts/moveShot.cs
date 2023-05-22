using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShot : MonoBehaviour
{
    public GameObject particula;
    private Rigidbody2D tiro;
    public int speed;
    void Start()
    {
        tiro = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tiro.velocity = new Vector2(speed, 0);   
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 8)
        {
            spawnerParticula();
            Destroy(this.gameObject);
        }
    }
    private void spawnerParticula()
    {
        Instantiate(particula, transform.position, Quaternion.identity);
    }
}

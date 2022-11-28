using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birld_move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private float time;
    public float Speed = 5f;

    private Vector2 move;

    void Update()
    {
        time -= Time.deltaTime;
        if(time <=0)
        {
            move = new Vector2(Random.Range(-1f,1f), Random.Range(-1, 1f));
            time = Random.Range(1f, 2f);
            if (move.x < transform.position.x)
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

            }

        }    
    }
    void FixedUpdate()
    {
        rb.AddForce(move * Speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Limit"))
        {
            move = -move;
        }
    }
}

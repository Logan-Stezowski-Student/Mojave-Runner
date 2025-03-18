using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    public float jumpForce = 2.0f;

    public bool isFalling = true;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFalling) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2d.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("On Collision Enter");
        if (other.gameObject.CompareTag("Ground")) 
        {
            isFalling = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            isFalling = true;
        }
    }
}

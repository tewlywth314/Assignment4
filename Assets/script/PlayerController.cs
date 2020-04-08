using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] KeyCode MoveUp;
    [SerializeField] KeyCode MoveDown;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    float rotate = 180;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move1();
    }
    void Move1()
    {
        if (Input.GetKeyDown(MoveUp))
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;
        }
        if (Input.GetKeyDown(MoveDown))
        {
            transform.position += new Vector3(0f, -1 * speed, -0f) * Time.deltaTime;
        }
        if (Input.GetKeyDown(MoveLeft))
        {
            transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;
        }
        if (Input.GetKeyDown(MoveRight))
        {
            transform.position += new Vector3(0f, 0f, -1 * speed) * Time.deltaTime;
        }
    }
    void move2()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(h, 0f, v);
    }
    void Move3()
    {
        if (Input.GetKeyDown(MoveUp))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
            if(rotate != 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0f;
            }
        }
        if (Input.GetKeyDown(MoveDown))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
            if (rotate != 180)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;
            }
        }
        if (Input.GetKeyDown(MoveLeft))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
            if (rotate != -90)
            {
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                rotate = -90f;
            }
        }
        if (Input.GetKeyDown(MoveRight))
        {
            rb.velocity = transform.forward * speed * Time.deltaTime;
            if (rotate != 90)
            {
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                rotate = 90f;
            }
        }
    }
}

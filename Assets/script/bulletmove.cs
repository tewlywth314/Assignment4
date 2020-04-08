using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);
        if(transform.position.z >= 50f || transform.position.x >= 50f || transform.position.y >= 50f )
        {
            Destroy(gameObject);
        }
    }
}

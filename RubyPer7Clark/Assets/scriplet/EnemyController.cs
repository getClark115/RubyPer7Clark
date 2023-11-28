using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed =3.0f ;
    public bool vertical;
    public float changeTime = 3.0f;

 
    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void FixedUpdate()
    {
        Vector2 positon = rigidbody2d.position;
        if(vertical)
        {
            positon.y  = positon.y + Time.deltaTime * speed;
        }
        else
        {
            positon.x = positon.x + Time.deltaTime + speed;
        }
    

        rigidbody2d.MovePosition(positon);
    }
}


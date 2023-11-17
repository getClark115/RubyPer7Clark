using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudyControls : MonoBehaviour
{
    public float speed = 5.3f;
    public int maxHealth = 55;
    public int Health { get { return currentHealth; } }
    public int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
        
        
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0,maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}

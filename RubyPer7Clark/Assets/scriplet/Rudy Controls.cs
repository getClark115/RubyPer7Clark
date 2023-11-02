using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudyControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 5.3f * horizontal * Time.deltaTime;
        position.y = position.y + 5.3f * vertical * Time.deltaTime;
        transform.position = position;
    }
}

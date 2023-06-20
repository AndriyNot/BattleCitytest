using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Швидкість руху танка
    public Sprite sprite;
    public lifemanager Lifemanager;
    private void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Отримання значення горизонтального вводу (A та D або стрілки вліво та вправо)
        float moveVertical = Input.GetAxis("Vertical"); // Отримання значення вертикального вводу (W та S або стрілки вгору та вниз)

        //transform.Translate(new Vector2(moveHorizontal, moveVertical) * moveSpeed * Time.deltaTime);

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;

        movement.Normalize();
       
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bolletEnemy"))
        {
            Destroy(gameObject);
            Lifemanager.Index += 1;
        }
    }
}

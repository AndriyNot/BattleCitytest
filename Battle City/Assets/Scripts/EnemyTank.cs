using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTank : MonoBehaviour
{
    //public Transform target; 
    //public float moveSpeed = 5f; 
    //public float rotationSpeed = 3f; 
    //public GameObject bulletPrefab;
    public CountManager CountEnemy;
    public PointManager Pointmanager;
    public lifemanager Lifemanager;

    private void Update()
    {
        //if (target != null)
        //{
        //    // Орієнтація танка в напрямку бази
        //    Vector3 direction = target.position - transform.position;
        //    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //    Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        //    // Рух танка до бази
        //    transform.position += transform.right * moveSpeed * Time.deltaTime;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bollet"))
        {
            Destroy(gameObject);
            CountEnemy.countDestroyEnemy();
            Pointmanager.pointmanager();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Lifemanager.Index += 1;
        }
    }

}

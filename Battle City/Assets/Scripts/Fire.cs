using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float bulletSpeed = 5;

    

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��������� ������ ��� � �������� ���� �� ������� �����
           Instantiate(bulletPrefab, transform.position, transform.rotation);

            // �������� ��������� Rigidbody2D ���
           

            // ������ ��������� �������� ���
            
        }
    }
}

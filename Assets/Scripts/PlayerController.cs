using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int actionPoints;
    void Start()
    {
        
    }

    void Update()
    {

        Move();
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

           
    }

    private void Move()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.localPosition += new Vector3(0, 1, 0);
        }
        else if (Input.GetKeyDown("a"))
        {
            transform.localPosition += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown("s"))
        {
            transform.localPosition += new Vector3(0, -1, 0);
        }
        else if (Input.GetKeyDown("d"))
        {
            transform.localPosition += new Vector3(1, 0, 0);
        }

    }
    private void Attack()
    {
        Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(playerPosition, EnemyController.instance.enemyPosition);
        if (hit.collider.CompareTag("Enemy"))
        {
            Debug.Log("IT FRIGGIN WORKS");
        }
    }
}

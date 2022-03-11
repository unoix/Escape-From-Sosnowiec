using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int actionPoints;
    [SerializeField] GameObject player;
    [SerializeField] GameObject camera;
    Vector3 playerPosition;
    void Start()
    {
        
    }

    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y);
        Move();
        if (Input.GetButtonDown("Fire1"))
        {
            //Attack();
        }
        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            
            Vector3 enemyPosition = new Vector3(enemy.transform.position.x, enemy.transform.position.y);
            Debug.DrawRay(playerPosition, (enemyPosition -= playerPosition));
        }


           
    }

    private void Move()
    {
        RaycastHit2D hit;
        if (Input.GetKeyDown("w"))
        {
            hit = Physics2D.Raycast(playerPosition, Vector2.up,1);
            Debug.DrawRay(playerPosition, Vector2.up, Color.red ,10);
            if (hit.collider.CompareTag("Enemy"))
            {
                Debug.Log("Enemy");
            }
            else
            {
                player.transform.localPosition += new Vector3(0, 1, 0);
            }
        }
        else if (Input.GetKeyDown("a"))
        {
            hit = Physics2D.Raycast(playerPosition, Vector2.left, 1);
            if (!(hit.collider.CompareTag("Enemy") || hit.collider.CompareTag("Obstacle")))
            {
                player.transform.localPosition += new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            hit = Physics2D.Raycast(playerPosition, Vector2.down, 1);
            if (!(hit.collider.CompareTag("Enemy") || hit.collider.CompareTag("Obstacle")))
            {
                player.transform.localPosition += new Vector3(0, -1, 0);
            }
        }
        else if (Input.GetKeyDown("d"))
        {
            hit = Physics2D.Raycast(playerPosition, Vector2.right, 1);
            if (!(hit.collider.CompareTag("Enemy") || hit.collider.CompareTag("Obstacle")))
            {
                player.transform.localPosition += new Vector3(1, 0, 0);
            }
        }
        camera.transform.position = player.transform.position -= new Vector3(0,0,5);
        player.transform.position += new Vector3(0, 0, 5);
        
    }
    


}

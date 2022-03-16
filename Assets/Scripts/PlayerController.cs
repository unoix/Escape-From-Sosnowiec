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
            foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if(!(playerPosition.x++ == enemy.transform.position.x))
                {
                    player.transform.localPosition += Vector3.up;
                    break;
                }
                else { Debug.Log("haha noob"); }
            }
        }
        else if (Input.GetKeyDown("a"))
        {
            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if (!(playerPosition.y-- == enemy.transform.position.y))
                {
                    player.transform.localPosition += Vector3.left;
                    break;
                }
                else { Debug.Log("haha noob"); }
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if (!(playerPosition.x-- == enemy.transform.position.x))
                {
                    player.transform.localPosition += Vector3.down;
                    break;
                }
                else { Debug.Log("haha noob"); }
            }
        }
        else if (Input.GetKeyDown("d"))
        {
            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if (!(playerPosition.x++ == enemy.transform.position.y))
                {
                    player.transform.localPosition += Vector3.right;
                    break;
                }
                else { Debug.Log("haha noob"); }
            }
        }
        camera.transform.position = player.transform.position -= new Vector3(0,0,5);
        player.transform.position += new Vector3(0, 0, 5);
        
    }
    


}

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
        if (Input.GetButtonDown("Fire1"))
        {
            //Attack();
        }
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {

            Vector3 enemyPosition = new Vector3(enemy.transform.position.x, enemy.transform.position.y);
            Debug.DrawRay(playerPosition, (enemyPosition -= playerPosition));
        } 
    }
}

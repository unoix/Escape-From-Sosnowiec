using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Vector2 enemyPosition;
    void Start()
    {  
    }
    void Update()
    {
        enemyPosition = new Vector2(transform.position.x, transform.position.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("There is more than one enemy");
        }
    }
    


    public Vector2 enemyPosition;
    void Start()
    {  
    }
    void Update()
    {
        enemyPosition = new Vector2(transform.position.x, transform.position.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;
    //settings
    [SerializeField] int timeLeft;
    private bool gamePaused;
    float points;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("There is more than one GameManager");
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

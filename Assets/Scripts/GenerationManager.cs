using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationManager : MonoBehaviour
{
    public static GenerationManager instance;
    [SerializeField] GameObject[] tiles;
    [SerializeField] GameObject[] Enemies;
    [SerializeField] int amount;
    [SerializeField] int MapSizeX;
    [SerializeField] int MapSizeY;
    private int index;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("There is more than one GenerationManager");
        }
    }
    private void Start()
    {
        Generate(MapSizeX, MapSizeY);
        GenerateEnemies(amount, MapSizeX, MapSizeY, Enemies);
    }
    void Generate(int MapSizeX , int MapSizeY)
    {
        Vector3 layerStartPosition = transform.position;
        for (int GeneratedMapY = 0; GeneratedMapY <= MapSizeY; GeneratedMapY++ )
        {
            for (int GeneratedMapX = 0; GeneratedMapX <= MapSizeX; GeneratedMapX++)
            {
                index = Random.Range(0, tiles.Length);
                GameObject newTile = Instantiate(tiles[index], transform.position, Quaternion.identity);
                transform.position += Vector3.right;
            }
            layerStartPosition += Vector3.up;
            transform.position = layerStartPosition;
        }

    }
    GameObject[] GenerateEnemies(int amount, int MapSizeX, int MapSizeY, GameObject[] enemyPrefabs)
    {
        GameObject[] spawnedEnemies = null;
        int addingIndex = 0;
        for (int generatedAmount = 0; generatedAmount <= amount; generatedAmount++)
        {
            int posX = Random.Range(0, MapSizeX);
            int posY = Random.Range(0, MapSizeY);
            int index = Random.Range(0, enemyPrefabs.Length);
            GameObject newEnemy = Instantiate(enemyPrefabs[index], new Vector3(posX, posY, 0), Quaternion.identity);
            GameObject[] addedEnemy = { newEnemy };
            spawnedEnemies.CopyTo(addedEnemy, addingIndex);
            addingIndex++;
        }
        return spawnedEnemies;
    }
}

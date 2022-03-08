using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationManager : MonoBehaviour
{
    public static GenerationManager instance;
    [SerializeField] GameObject[] tiles;
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
        Generate(10, 10);
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
}

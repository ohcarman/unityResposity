using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public List<GameObject> activeTiles = new List<GameObject>();
    float tileLength = 250;
    float distanceBeforeGeneration = 100;
    float curY = 0;//; y position of last tile
    float curX = 0;
    public Transform playerPos;
    int spawnCounter = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPos.position.z > distanceBeforeGeneration + curX)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    public void SpawnTile(int tile)
    {
        // instantiates new tile object v
        GameObject newTile = Instantiate(tilePrefabs[tile], ((transform.forward * (tileLength)) + (transform.forward * curX)) + ((transform.up * curY) - (transform.up * 20)), transform.rotation);
        curY -= 20;
        curX += tileLength;
        activeTiles.Add(newTile);
        spawnCounter++;
        if (spawnCounter == 3)
        {
            DeleteTile();
            spawnCounter -= 1;
        }
    }

    public void DeleteTile()
    {

        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
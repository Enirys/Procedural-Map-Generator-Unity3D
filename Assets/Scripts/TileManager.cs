using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    public GameObject currentTile; //Stores the last blue tile Spawned
    private GameObject currentYellowTile; //Stores the last blue tile Spawned

    public GameObject[] yellowTilePrefabs; //Array of yellow tiles prefabs

    public GameObject[] normalTilePrefabs; //Array of normal tiles prefabs
    public GameObject[] changeTilePrefabs; //Array of normal tiles prefabs (Player changes direction when colliding with this tile)

    public GameObject diamondPrefab;

    private int startNormalIndex = 0;
    private int startNormalTilesToSpawn = 10;
    private int normalIndex;

    private float timeBtwSpawns; //Remaining time to spawn tiles 
    public float startTimeBtwSpawns = 3f; // Time between tiles spawn

	// Use this for initialization
	void Start ()
    {
        //Spawn 10 tiles at the start of the game

        SpawnNormalTiles(startNormalTilesToSpawn,startNormalIndex);
        normalIndex = startNormalIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int nbTilesToSpawn = Random.Range(5, 16); // Generates a random number of tiles to spawn

            if(normalIndex == 0)                /* Changes the index of */
            {                                   /* tile to spawn */
                normalIndex = 1;
            }
            else if(normalIndex == 1)
            {
                normalIndex = 0;
            }

            SpawnNormalTiles(nbTilesToSpawn,normalIndex);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

    }

    public void SpawnYellowTile(int randomIndex) // Spawns Yellow Tiles with an offset of 1 or -1 on z-axis or x-axis
    {
        /*Vector3 offset;

        int rand = Random.Range(-2, 1) + 1;
        if(randomIndex == 0)
        {
            offset = new Vector3(0, 0, rand);
        }
        else
        {
            offset = new Vector3(rand, 0, 0);
        }*/

        currentTile = (GameObject)Instantiate(yellowTilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }

    public void SpawnChangeTile(int randomIndex) // Spawns a tile that changes the player's direction on x-axis or z-axis
    {
        currentTile = (GameObject)Instantiate(changeTilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }

    public void SpawnNormalTiles(int nbTilesToSpawn, int randomIndex) // Spawns nbTilesToSpawn(number of tiles to spawn) normal tiles, with the index of randomIndex
    {
        int rand = Random.Range(1, nbTilesToSpawn / 2);

        for (int i = 0; i <= nbTilesToSpawn; i++)
        {
            SpawnTile(randomIndex);

            if(i == rand)
            {
                SpawnYellowTile(randomIndex);
            }
        }

        SpawnChangeTile(randomIndex);
    }

    public void SpawnTile(int randomIndex) //Spawns one normal tile from array 
    {
        currentTile = (GameObject)Instantiate(normalTilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }
}

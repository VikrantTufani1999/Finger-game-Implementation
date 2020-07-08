using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesGenerator : MonoBehaviour
{
    private Camera mainCam;
    public GameObject Player;
    public GameObject[] Tiles;
    float spawnY;
    // Use this for initialization
    void Start()
    {
        mainCam = Camera.main;
        spawnY = mainCam.transform.position.y + 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCam.transform.position.y < Player.transform.position.y)
        {
            Vector3 targetPos = new Vector3
                (
                    mainCam.transform.position.x,
                    Player.transform.position.y,
                    mainCam.transform.position.z
                );

            mainCam.transform.position = Vector3.Lerp
                 (
                     mainCam.transform.position,
                     targetPos,
                     0.5f
                 );
        } //endif

        if (mainCam.transform.position.y > spawnY)
        {
            spawnY += Random.Range(3f, 10.5f);
            float spawnX = Random.Range(-3f, 3f);
            SpawnTile(new Vector3(spawnX, spawnY));
        }
    }

    void SpawnTile(Vector3 pos)
    {
        pos.z = 0f;
        int RandomTile = Random.Range(0, Tiles.Length - 1);
        Instantiate(Tiles[RandomTile], pos, Tiles[RandomTile].transform.rotation);
    }
}
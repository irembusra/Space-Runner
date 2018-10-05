using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WayGenerator : MonoBehaviour {

    public GameObject[] ways;
    private Transform playerTransform;
    private float spawnZ = -6.0f;
    private float tileLength = 40.0f;
    private float safeZone =43.0f;
    private int amnTilesOnScreen = 7;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeWays;
	// Use this for initialization
	private void Start () {
        activeWays = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i< amnTilesOnScreen; i ++ )
        {
           
                SpawnWay();
           
        }
    }
	
	// Update is called once per frame
	private void Update () {
		
        if(playerTransform.position.z - safeZone> (spawnZ - amnTilesOnScreen * tileLength))

        {
            SpawnWay();
            DeleteWay();
        }
    }
    private void SpawnWay(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
            go = Instantiate(ways[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(ways[prefabIndex]) as GameObject; 
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeWays.Add(go);
    }
    private void DeleteWay()
    {
        Destroy(activeWays[0]);
        activeWays.RemoveAt(0);
    }
    private int RandomPrefabIndex()
    {
        if (ways.Length <= 1)
            return 0;
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, ways.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;

    }
}

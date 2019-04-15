using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileObject : MonoBehaviour
{
    public GameObject tilePrefab;
    TileData tileData; 
    // Update is called once per frame
    void Update()
    {
        
    }

    public TileObject createTile(TileData inTileData)
    {
        tileData = inTileData;
        Instantiate(tilePrefab);

        return this; 
    }
}

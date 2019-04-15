using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TILE_TYPE
{
    UNKNOWN = 0,
    SIMPLE_GREEN = 1,
}


public enum BUILDING_TYPE
{
    UNKNOWN = 0,
    MAIN_BUILDING = 2,
    ROCKS_RESOURCE = 3,
    WOODS_RESOURCE = 4,
    COINS_RESOURCE = 5,
    SIMPLE_HOUSE = 6,
    DECOR = 7,
}

public class LevelManager : MonoBehaviour
{

    // Dictionary<TILE_TYPE, GameObject> titlePrfabsTable;
    // Dictionary<BUILDING_TYPE, GameObject> buildingPrfabsTable;

    public GameObject tilePrefab;
    public Transform tileHolder;

    public static LevelManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        MapData data = new MapData();
        createLevelel(ref data);
    }
    public void createLevelel(ref MapData inMapData)
    {
        for (int x = 0; x < inMapData.width; x++)
        {
            for (int z = 0; z < inMapData.length; z++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(x,0,z), Quaternion.identity);
                tile.transform.SetParent(tileHolder);
            }
            
        }
    }

    // GameObject getTitlePrefabByType(TILE_TYPE inType)
    // {
    //     GameObject obj;
    //     return titlePrfabsTable.TryGetValue(inType, out obj) ? obj : null;
    // }

    //  GameObject getBuildingPrefabByType(BUILDING_TYPE inType)
    // {
    //     GameObject obj;
    //     return buildingPrfabsTable.TryGetValue(inType, out obj) ? obj : null;
    // }
}

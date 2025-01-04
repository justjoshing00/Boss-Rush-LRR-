using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner
{
    public void SpawnBuilding(GameObject building, Vector3 pos)
    {

        GameObject.Instantiate(building, pos, building.transform.rotation);
        
    }
}

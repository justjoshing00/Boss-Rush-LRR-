using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    List<GameObject> Buildings;
    BuildingSpawner buildingSpawner;
    [SerializeField] GameObject building;

    public static BuildingManager buildingManagerInstance { get; private set; }
    private void Awake()
    {
        if (buildingManagerInstance != null && buildingManagerInstance != this)
        {
            Destroy(this);
        }
        else
        {
            buildingManagerInstance = this;
        }
    }

    public void Start()
    {
        Buildings = new();
        buildingSpawner = new();
    }


    public void CreateBuilding(Vector3 pos)
    {
        buildingSpawner.SpawnBuilding(building, pos);//TODO: fix this
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    List<GameObject> Turrets;
    TurretSpawner TurretSpawner;
    [SerializeField] GameObject Turret;

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
        Turrets = new();
        TurretSpawner = new();
    }


    public void CreateBuilding(Vector3 pos)
    {
        TurretSpawner.SpawnTurret(Turret, pos);//TODO: fix this
    }

   
}

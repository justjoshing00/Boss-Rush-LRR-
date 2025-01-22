using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuildingManager : MonoBehaviour
{

    TurretSpawner turretSpawner;
    TrapSpawner trapSpawner;
    BossSpawner bossSpawner;

    [SerializeField] GameObject OMNITurret;
    [SerializeField] GameObject BASETurret;
    [SerializeField] GameObject TWINTurret;
    [SerializeField] GameObject AATurret;
    [SerializeField] GameObject BOMBTurret;
    List<GameObject> TurretList; // need this for randomization
    

    [SerializeField] GameObject Tanktrap;
    [SerializeField] GameObject Wall;

    [SerializeField] GameObject catboss;
    [SerializeField] GameObject eyesboss;
    [SerializeField] GameObject tankboss;
    [SerializeField] GameObject catgodboss;


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
        TurretList = new();
        

        TurretList.Add(OMNITurret);
        TurretList.Add(BASETurret);
        TurretList.Add(TWINTurret);
        TurretList.Add(AATurret);
        TurretList.Add(BOMBTurret);
        
        turretSpawner = new();
        bossSpawner = new();
        trapSpawner = new();
        //int RandomBuilding = UnityEngine.Random.Range(1, 5); // TODO: think about when we need this


    }



    public void CreateBuilding(Vector3 pos)
    {
        
        turretSpawner.SpawnTurret(BASETurret, pos);//TODO: fix this
    }

   
}

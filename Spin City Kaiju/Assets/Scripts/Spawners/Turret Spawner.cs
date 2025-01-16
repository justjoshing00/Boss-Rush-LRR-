using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawner
{
    public void SpawnTurret(GameObject turret, Vector3 pos)
    {

        GameObject.Instantiate(turret, pos, turret.transform.rotation);
        
    }
}

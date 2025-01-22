using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicTurret: MonoBehaviour
{
    public GameObject projectile;
    TurretStats stats;
    Action fire; // have a third party set this
     

    void Start()
    {
        //InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);
    }

    void LaunchProjectile()
    {


        GameObject instance = Instantiate(projectile);

        instance.transform.position += Vector3.left;
    }
}

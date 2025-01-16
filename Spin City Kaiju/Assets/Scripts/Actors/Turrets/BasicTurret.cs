using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTurret:Turret
{
    public GameObject projectile;

    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);
    }

    void LaunchProjectile()
    {
        GameObject instance = Instantiate(projectile);

        instance.transform.position += Vector3.left;
    }
}

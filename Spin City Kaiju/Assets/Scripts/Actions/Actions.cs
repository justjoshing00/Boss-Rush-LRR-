using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions
{
    public void OneDTurretFire(GameObject projectile)
    {
        GameObject instance = GameObject.Instantiate(projectile);
    }
    public void FourDTurretFire(GameObject projectile)
    {
        GameObject instanceup = GameObject.Instantiate(projectile);
        GameObject instancedown = GameObject.Instantiate(projectile);
        GameObject instanceleft = GameObject.Instantiate(projectile);
        GameObject instanceright = GameObject.Instantiate(projectile);
    }
    public void TwinLinkedTurretFire(GameObject projectile)
    {
        GameObject instance1 = GameObject.Instantiate(projectile);
        GameObject instance2 = GameObject.Instantiate(projectile);
    }
    public void BombTurretFire(GameObject projectile)
    {

    }
    public void AntiProjectileField()
    {

    }
    public void EnergyField()
    {

    }

    public void LaserFire(GameObject projectile)
    {
        GameObject instance = GameObject.Instantiate(projectile);
    }
    public void PlasmaFire(GameObject projectile)
    {
        GameObject instance = GameObject.Instantiate(projectile);
    }

   
}

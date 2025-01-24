using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner
{
    public void SpawnBoss(GameObject Boss, Vector3 pos)
    {
        GameObject.Instantiate(Boss, pos, Boss.transform.rotation);
    }
}

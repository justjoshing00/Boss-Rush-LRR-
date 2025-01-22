using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public void SpawnBoss(GameObject Boss, Vector3 pos)
    {
        GameObject.Instantiate(Boss, pos, Boss.transform.rotation);
    }
}

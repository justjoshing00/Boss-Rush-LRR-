using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner
{
    public void SpawnTrap(GameObject Trap, Vector3 pos)
    {
        GameObject.Instantiate(Trap, pos, Trap.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public void SpawnTrap(GameObject Trap, Vector3 pos)
    {
        GameObject.Instantiate(Trap, pos, Trap.transform.rotation);
    }
}

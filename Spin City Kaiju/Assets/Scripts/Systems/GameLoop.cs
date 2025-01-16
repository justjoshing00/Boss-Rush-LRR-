using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update

    InputSystem inputSystem;
    

    /*
    PREP PHASE
    click building you want
    click where you want it
    building is placed - money
    FIGHT PHASE
    boss summons enemies
    boss makes attacks(?)
    win condition - kill the boss
    loss condition -????
    */

    void Start()
    {
        inputSystem = new();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);
        inputSystem.MakeBuilding();
    }
}

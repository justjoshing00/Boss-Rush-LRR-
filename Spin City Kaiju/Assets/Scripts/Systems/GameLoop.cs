using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update

    InputSystem inputSystem;
    [SerializeField] int startingMoney = 1000;


    /*
    click where you want the building
    building is placed - money
    boss makes attacks
    win condition - kill the boss
    loss condition - boss moves to end point of level
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

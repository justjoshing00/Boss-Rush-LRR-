using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update

    InputSystem inputSystem;

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

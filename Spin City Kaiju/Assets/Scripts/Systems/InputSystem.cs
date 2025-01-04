using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem
{
    Camera cam;
    
    public void MakeBuilding()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitdata;
            if (Physics.Raycast(ray, out hitdata))
            {
                BuildingManager.buildingManagerInstance.CreateBuilding(hitdata.point);
            }
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurretSelection : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button BasicTurretButton, AllDirectionalTurretButton, ZapTurretButton;
    Turret CurrentTurret;

    BasicTurret bturret;
    AllDirectionTurret aturret;
    ZapTurret zturret;
    void Start()
    {

        BasicTurretButton.onClick.AddListener(()=> SelectTurret(bturret));
        AllDirectionalTurretButton.onClick.AddListener(() => SelectTurret(aturret));
        ZapTurretButton.onClick.AddListener(() => SelectTurret(zturret));

    }

    void SelectTurret(Turret turret)
    {
        CurrentTurret = turret;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(daggerPrefab, spawnPoint1.position, spawnPoint1.rotation); 
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

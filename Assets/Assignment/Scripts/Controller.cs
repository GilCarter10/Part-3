using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CinemachineVirtualCamera vCamera;
    
    //public int redDiscsLeft = 4;
    //public int blueDiscsLeft = 4;
    public int discNum = 0;
    int oldDiscNum;
    public List<Mover> Discs;


    void Start()
    {
        SpawnDisc();
    }

    void Update()
    {

        if (discNum <= 8)
        {
            if (Discs[discNum].finished == true)
            {
                oldDiscNum = discNum;
                StartCoroutine(ChangeDisc());

            }
        }
    }

    void SpawnDisc()
    {
        //Instantiate(Discs[discNum]);
        Discs[discNum].gameObject.transform.position = new Vector3 (0, -3.12f, 0);
        vCamera.Follow = Discs[discNum].gameObject.transform;
        Discs[discNum].moveable = true;
    }


    IEnumerator ChangeDisc()
    {
        discNum++;
        yield return new WaitForSeconds(5f);
        SpawnDisc();
        yield return null;
        
    }

}

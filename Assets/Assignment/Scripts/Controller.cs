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
    public List<Disc> Discs;


    void Start()
    {
        SpawnDisc();
    }

    void Update()
    {
        Debug.Log(Discs[discNum].moveable);
        if (Discs[discNum].finished == true)
        {
            StartCoroutine(ChangeDisc());
            oldDiscNum = discNum;
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
        yield return new WaitForSeconds(5f);
        while (discNum == oldDiscNum)
        {
            discNum ++;
            SpawnDisc();
            yield return null;
        }
    }

}

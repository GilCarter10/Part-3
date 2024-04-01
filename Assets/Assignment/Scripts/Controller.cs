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
    public List<Disc> Discs;


    void Start()
    {
        SpawnDisc();
    }

    void Update()
    {
        Debug.Log(Discs[discNum]);
        if (Discs[discNum].moveable == false)
        {
            StartCoroutine(ChangeDisc());
        }
    }

    void SpawnDisc()
    {
        //Instantiate(Discs[discNum]);
        Discs[discNum].gameObject.SetActive(true);
        vCamera.Follow = Discs[discNum].gameObject.transform;

    }


    IEnumerator ChangeDisc()
    {
        yield return new WaitForSeconds(5f);
        discNum++;
        SpawnDisc();

    }

}

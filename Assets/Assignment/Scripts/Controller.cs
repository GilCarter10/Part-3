using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public CinemachineVirtualCamera vCamera;

    public static int stateNum = 1;

    public int discNum = 0;
    int oldDiscNum;

    public List<Mover> Discs;

    public Image underlineP1;
    public Image underlineP2;


    void Start()
    {
        underlineP1.gameObject.SetActive(true);
        underlineP2.gameObject.SetActive(false);
    }

    void Update()
    {
        StartEndState.CheckState(stateNum);

        if (0 <= discNum && discNum < 8)
        {
            if (Discs[discNum].finished == true)
            {
                oldDiscNum = discNum;
                StartCoroutine(ChangeDisc());

            }
        }
        
        if (stateNum == 2)
        {
            SpawnDisc();
            stateNum++;
        }

    }

    public void SpawnDisc()
    {
        Discs[discNum].gameObject.transform.position = new Vector3 (0, -3.12f, 0);
        vCamera.Follow = Discs[discNum].gameObject.transform;
        Discs[discNum].moveable = true;
        if (discNum % 2 == 0) //if even
        {
            underlineP1.gameObject.SetActive(true);
            underlineP2.gameObject.SetActive(false);
        }
        if (discNum % 2 == 1) //if odd
        {
            underlineP1.gameObject.SetActive(false);
            underlineP2.gameObject.SetActive(true);
        }
    }


    IEnumerator ChangeDisc()
    {
        discNum++;
        yield return new WaitForSeconds(5f);
        if (discNum < 8)
        {
            SpawnDisc();
        }
        else
        {
            stateNum = 4;
        }

        
        yield return null;
        
    }



}

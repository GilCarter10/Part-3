using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public CinemachineVirtualCamera vCamera;
    

    public int discNum = 0;
    public static int stateNum = 1;
    int oldDiscNum;
    public List<Mover> Discs;

    public Image underlineP1;
    public Image underlineP2;

    static bool reset = false;

    void Start()
    {
        underlineP1.gameObject.SetActive(true);
        underlineP2.gameObject.SetActive(false);
    }

    void Update()
    {

        StartEndState.CheckState(stateNum);

        if (0 < discNum && discNum < 8)
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

        if (discNum >= 8)
        {
            stateNum = 4;
        }

        if (reset)
        {
            discNum = 0;
            SpawnDisc();
            reset = false;
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
        SpawnDisc();
        yield return null;
        
    }


    public static void ResetGame()
    {
        reset = true;
    }


}

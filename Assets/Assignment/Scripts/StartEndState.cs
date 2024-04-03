using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StartEndState : MonoBehaviour
{

    public GameObject TitleObject;
    public GameObject EndObject;

    static TextMeshProUGUI Title;
    static TextMeshProUGUI End;

    private void Start()
    {
        Title = TitleObject.GetComponent<TextMeshProUGUI>();
        End = EndObject.GetComponent<TextMeshProUGUI>();

        Title.gameObject.SetActive(true);
        End.gameObject.SetActive(false);
    }

    public static void CheckState(int num)
    {
        if (num == 1) //start + play
        {
            if (Input.GetMouseButtonDown(0))
            {
                Title.gameObject.SetActive(false);
                Controller.stateNum++;
            }

        }

        if (num == 4) //end
        {
            End.gameObject.SetActive(true);

            if (BlueDisc.blueScore > RedDisc.redScore)
            {
                End.color = Color.blue;
                End.text = "BLUE WINS";
            }

            if (RedDisc.redScore > BlueDisc.blueScore)
            {
                End.color = Color.red;
                End.text = "RED WINS";
            }

            if (BlueDisc.blueScore == RedDisc.redScore)
            {
                End.color = Color.white;
                End.text = "TIE GAME";
            }

        }
        else
        {
            End.gameObject.SetActive(false);
        }

    }


}

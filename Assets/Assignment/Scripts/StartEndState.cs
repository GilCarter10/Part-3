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
    public GameObject PlayAgainObject;

    static TextMeshProUGUI Title;
    static TextMeshProUGUI End;
    static TextMeshProUGUI PlayAgain;

    private void Start()
    {
        Title = TitleObject.GetComponent<TextMeshProUGUI>();
        End = EndObject.GetComponent<TextMeshProUGUI>();
        PlayAgain = PlayAgainObject.GetComponent<TextMeshProUGUI>();

        Title.gameObject.SetActive(true);
        End.gameObject.SetActive(false);
        PlayAgain.gameObject.SetActive(false);
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
            PlayAgain.gameObject.SetActive(true);

            if (BlueDisc.blueScore > RedDisc.redScore)
            {
                End.color = new Color(114, 156, 231);
                End.text = "BLUE WINS";
            }

            if (RedDisc.redScore > BlueDisc.blueScore)
            {
                End.color = new Color(189, 66, 67);
                End.text = "RED WINDS";
            }

            if (BlueDisc.blueScore == RedDisc.redScore)
            {
                End.color = Color.white;
                End.text = "TIE GAME";
            }

            if (Input.GetMouseButtonDown(0))
            {
                Controller.ResetGame();
                Controller.stateNum = 2;
            }

        }
        else
        {
            End.gameObject.SetActive(false);
        }

    }


}

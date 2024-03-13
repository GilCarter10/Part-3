using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static CharacterControl Instance;
    public TextMeshProUGUI textMeshy;
    Type villagerType;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

    private void Update()
    {
        villagerType = SelectedVillager.GetType();
        textMeshy.text = villagerType.ToString();
        if (SelectedVillager == null)
        {
            textMeshy.text = "None Selected";
        }
    }

}

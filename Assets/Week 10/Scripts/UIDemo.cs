using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer spriteRenderer;
    public Color start;
    public Color end;
    float interpolation;
    
    public void SliderValueHasChanged(Single value)
    {
        interpolation = value/60;
    }

    private void Update()
    {
        spriteRenderer.color = Color.Lerp(start, end, interpolation);
    }

    public void DropdownSelectionHasChanged(int value)
    {
        Debug.Log(dropdown.options[value].text);
    }

}

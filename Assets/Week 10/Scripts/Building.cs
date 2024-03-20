using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    Vector3 goalScaleFirst;
    Vector3 goalScaleSecond;
    Vector3 goalScaleThird;
    Vector3 start = new Vector3(0.1f, 0.1f, 0.1f);
    float interpolation1;
    float interpolation2;
    float interpolation3;
    public float speed;
    
    private void Start()
    {
        goalScaleFirst = first.transform.localScale;
        goalScaleSecond = second.transform.localScale;
        goalScaleThird = third.transform.localScale;
        first.SetActive(false);
        second.SetActive(false); 
        third.SetActive(false);
        interpolation1 = 0;
        interpolation2 = 0;
        interpolation3 = 0;

        StartCoroutine(Build());
    }
    IEnumerator Build()
    {
        
        while (interpolation1 < 1)
        {
            first.SetActive(true);
            first.transform.localScale = Vector3.Lerp(start, goalScaleFirst, interpolation1);
            interpolation1 += Time.deltaTime * speed;
            Debug.Log("test");
            yield return null;
        }
        
        while (interpolation2 < 1)
        {
            second.SetActive(true);
            second.transform.localScale = Vector3.Lerp(start, goalScaleSecond, interpolation2);
            interpolation2 += Time.deltaTime * speed;
            yield return null;
        }
        
        while (interpolation3 < 1)
        {
           third.SetActive(true);
           third.transform.localScale = Vector3.Lerp(start, goalScaleThird, interpolation3);
           interpolation3 += Time.deltaTime * speed;
           yield return null;
        }

    }

}

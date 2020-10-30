using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TemperatureTester : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject boxFren;


    //Uses Hot/Cold
    public GameObject frozenBoxFren;

    //Does not use Hot/Cold
    public GameObject warmedBoxFren;

    public bool bFreezeData = false;

    void Start()
    {
        boxFren = GameObject.Instantiate(frozenBoxFren);

        InitBoxes(bFreezeData);
    }

    // Update is called once per frame
    void Update()
    {
        boxFren.transform.position = new Vector3(Mathf.Sin(Time.time) + 20f, 0, Mathf.Cos(Time.time));
        if (bFreezeData)
        {
            boxFren.GetComponent<HotData>().time = Time.time;

        }
        else
        {
            boxFren.GetComponent<WarmData>().time = Time.time;
        }
    }


    public void InitBoxes(bool bUseColdDataPointer)
    {
        bFreezeData = bUseColdDataPointer;

        Destroy(boxFren);


        if (bUseColdDataPointer)
        {
            boxFren = GameObject.Instantiate(frozenBoxFren);
            boxFren.GetComponent<HotData>().time = Time.time;

        }
        else
        {
            boxFren = GameObject.Instantiate(warmedBoxFren);
            boxFren.GetComponent<WarmData>().time = Time.time;
        }
    }

}

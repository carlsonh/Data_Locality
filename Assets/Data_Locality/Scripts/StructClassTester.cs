using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class StructClassTester : MonoBehaviour
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
        boxFren.transform.position = new Vector3(Mathf.Sin(Time.time), 0, Mathf.Cos(Time.time));

    }


    public void InitBoxes(bool bUseColdDataPointer)
    {
        bFreezeData = bUseColdDataPointer;

        Destroy(boxFren);
        boxFren = GameObject.Instantiate(frozenBoxFren);

        if (bUseColdDataPointer)
        {

            boxFren.GetComponent<TestScript>().bUseStructData = true;

        }
        else
        {

            boxFren.GetComponent<TestScript>().bUseStructData = false;
        }
    }
}

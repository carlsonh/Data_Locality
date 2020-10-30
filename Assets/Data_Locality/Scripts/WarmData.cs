using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmData : MonoBehaviour {
    public float time;
    public ColdData frosty = new ColdData ();

    private void Awake () {
        frosty.floater = time;
        frosty.floats[0] = time;
        Debug.Log ("Warmed Init'd");

    }

}
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class HotData : MonoBehaviour {
    public float time;
    public unsafe FrozenData * frostyer;

    public unsafe void Awake () {

        FrozenData _t = new FrozenData ();

        frostyer = & _t;

        frostyer->floater = time;
        frostyer->floats[0] = time;

        Debug.Log ("Frozen Init'd");

    }

}
using System;
using System.Runtime.CompilerServices;
//using Unity.Burst;
using Unity.Collections;
using UnityEngine;

public struct FrozenData {

    public float floater;

    public unsafe fixed float floats[100000];

}
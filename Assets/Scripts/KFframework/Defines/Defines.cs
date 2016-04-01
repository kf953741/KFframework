using UnityEngine;
using System.Collections;


public enum EnumObjectState
{
    None,
    Initial,
    Loading,
    Ready,
    Disable,
    Closeing
}

public enum EnumUIType : int
{
    None = -1,
    TestOne = 0,
    TestTwo = 1,
}

public delegate void StateChangeEvent(Object ui, EnumObjectState newState, EnumObjectState oldState);

public class Defines  {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

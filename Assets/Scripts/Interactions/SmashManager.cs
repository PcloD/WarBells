﻿using Interactions;
using UnityEngine;


public class SmashManager : MonoBehaviour
{
	public Smashable BigBell;
	public Smashable MediumBell;
	public Smashable SmallBell;

	void Start()
	{
		BigBell.Reset();
		MediumBell.Reset();
		SmallBell.Reset();
	}
	
	public void Smash ()
	{
		BigBell.Smash();
		MediumBell.SmashAfter(1.2f);
		SmallBell.SmashAfter(1.8f);
	}


}

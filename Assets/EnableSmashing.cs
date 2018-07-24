﻿using System.Collections;
using System.Collections.Generic;
using Interactions;
using UnityEngine;

public class EnableSmashing : MonoBehaviour {

	void Start () {
		foreach (var sel in gameObject.GetComponentsInChildren<Selectable>())
		{
			sel.enabled = false;
		}
		foreach (var sel in gameObject.GetComponentsInChildren<Smashable>())
		{
			sel.enabled = false;
		}
	}
	
	public void DoEnableSmashing () {
		foreach (var sel in gameObject.GetComponentsInChildren<Selectable>())
		{
			sel.enabled = true;
		}
		foreach (var sel in gameObject.GetComponentsInChildren<Smashable>())
		{
			sel.enabled = true;
		}
	}
}

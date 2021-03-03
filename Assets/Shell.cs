using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : Item
{
	public override void UseItem()
	{
		Item.Shells += 1;
		base.UseItem();
		Debug.Log("You grabbed a big shell");
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : Item
{
	public override void UseItem()
	{
		Item.Money += 2;
		base.UseItem();
		Debug.Log("Gained 2 Money!");
		
	}
}

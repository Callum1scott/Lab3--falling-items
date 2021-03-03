using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gold : Item
{
	public override void UseItem()
	{
		Item.Money += 5;
		base.UseItem();
		Debug.Log("Gained 5 Money!");
		
	}
}


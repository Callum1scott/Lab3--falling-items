using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Item
{
	public override void UseItem()
	{
		Item.Money = 0;
		Item.Shells = 0;
		base.UseItem();
		Debug.Log("You lose everything!");
		
	}
}

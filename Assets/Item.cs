using UnityEngine;

public class Item : MonoBehaviour
{
	public string Name;
	public bool Consumable;
	
	public static int Money = 0;
	public static int Shells = 0;

	private void OnMouseDown()
	{
		UseItem();
	}

	public virtual void UseItem()
	{
		Debug.Log("Using " + Name);
		Debug.Log("You have " + Money + "Moneys and " + Shells + "Shells");
		if (Consumable)
		{
			Destroy(this.gameObject);
			Debug.Log("You have " + Money + "Moneys and " + Shells + "Shells");
		}
	}
}

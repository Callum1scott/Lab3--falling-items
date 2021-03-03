using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameman : MonoBehaviour
{
    public Text textBox;
    public float Timer;
    public float TImerX;
   

    public GameObject[] Itmes;

    private void Start()
    {
        TImerX = Timer * .25f;

    }

    void Update()
    {
        Debug.Log("work");

        textBox.text = (Item.Money + " Moneys and " + Item.Shells);

        Timer = Timer - 1;

        
        Debug.Log("IT IS SHIT");

        if(Timer <= 0)
        {
            Instantiate(Itmes[Random.Range(0, Itmes.Length)], new Vector3(Random.Range(-7, 7), 5.5f ,  0), Quaternion.identity);
            Timer = 200;
           
        }
    }
}

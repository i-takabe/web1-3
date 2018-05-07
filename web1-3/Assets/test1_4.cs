using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int PlayerHP = 1000;
    private int PlayerPower = 50;

    public void Attack()
    {
        Debug.Log(this.PlayerPower + "のダメージ!");
    }
}




public class test1_4 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] points = new int[5];

        Player player1 = new Player();

        Vector2 pos1 = new Vector2(5.0f, 7.0f);
        Vector2 pos2 = new Vector2(10.0f, 10.0f);
        Vector2 posM = pos2 - pos1;

        for(int i = 0; i < points.Length; i++)
        {
            points[i] = i * 10;

            Debug.Log("points["+i+"] = "+ points[i]);
        }

        player1.Attack();

        Debug.Log(posM);

        float M = posM.magnitude;
        Debug.Log(M);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

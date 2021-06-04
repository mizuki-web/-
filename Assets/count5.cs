using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count5 : MonoBehaviour
{
	public int P5total;
	public int D5total;
	// Update is called once per frame
	void Update()
	{
		GameObject S5 = transform.Find("S/Cube").gameObject;
		GameObject D5 = transform.Find("D/Cube").gameObject;


		int P51 = D5.GetComponent<VCC5>().PFive;
		int P52 = S5.GetComponent<VCC5>().PFive;

		P5total = P51 + P52; //同じ種類のカードの合計値を算出

		int D51 = D5.GetComponent<VCC5>().DFive;
		int D52 = S5.GetComponent<VCC5>().DFive;

		D5total = D51 + D52; //同じ種類のカードの合計値を算出
	}
}

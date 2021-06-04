using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tencount : MonoBehaviour
{
	public int P10total;
	public int D10total;
	// Update is called once per frame
	void Update()
	{
		GameObject S10 = transform.Find("S/Cube").gameObject;
		GameObject D10 = transform.Find("D/Cube").gameObject;

		int P101 = D10.GetComponent<VCC10>().PTen;
		int P102 = S10.GetComponent<VCC10>().PTen;

		P10total = P101 + P102; //同じ種類のカードの合計値を算出

		int D101 = D10.GetComponent<VCC10>().DTen;
		int D102 = S10.GetComponent<VCC10>().DTen;

		D10total = D101 + D102; //同じ種類のカードの合計値を算出
	}
}

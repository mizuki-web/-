using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count2 : MonoBehaviour
{
	public int P2total;
	public int D2total;
	// Update is called once per frame
	void Update()
	{
		GameObject S2 = transform.Find("S/Cube").gameObject;
		GameObject D2 = transform.Find("D/Cube").gameObject;


		int P21 = D2.GetComponent<VCC2>().PTwo;
		int P22 = S2.GetComponent<VCC2>().PTwo;

		P2total = P21 + P22; //同じ種類のカードの合計値を算出

		int D21 = D2.GetComponent<VCC2>().DTwo;
		int D22 = S2.GetComponent<VCC2>().DTwo;

		D2total = D21 + D22; //同じ種類のカードの合計値を算出
	}
}

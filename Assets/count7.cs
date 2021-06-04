using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count7 : MonoBehaviour
{
	public int P7total;
	public int D7total;
	// Update is called once per frame
	void Update()
	{
		GameObject S7 = transform.Find("S/Cube").gameObject;
		GameObject D7 = transform.Find("D/Cube").gameObject;


		int P71 = D7.GetComponent<VCC7>().PSeven;
		int P72 = S7.GetComponent<VCC7>().PSeven;

		P7total = P71 + P72; //同じ種類のカードの合計値を算出

		int D71 = D7.GetComponent<VCC7>().DSeven;
		int D72 = S7.GetComponent<VCC7>().DSeven;

		D7total = D71 + D72; //同じ種類のカードの合計値を算出
	}
}

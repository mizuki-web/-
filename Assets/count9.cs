using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count9 : MonoBehaviour
{
	public int P9total;
	public int D9total;
	// Update is called once per frame
	void Update()
	{
		GameObject S9 = transform.Find("S/Cube").gameObject;
		GameObject D9 = transform.Find("D/Cube").gameObject;


		int P91 = D9.GetComponent<VCC9>().PNine;
		int P92 = S9.GetComponent<VCC9>().PNine;

		P9total = P91 + P92; //同じ種類のカードの合計値を算出

		int D91 = D9.GetComponent<VCC9>().DNine;
		int D92 = S9.GetComponent<VCC9>().DNine;

		D9total = D91 + D92; //同じ種類のカードの合計値を算出
	}
}

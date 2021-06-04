using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count8 : MonoBehaviour
{
	public int P8total;
	public int D8total;
	// Update is called once per frame
	void Update()
	{
		GameObject S8 = transform.Find("S/Cube").gameObject;
		GameObject D8 = transform.Find("D/Cube").gameObject;


		int P81 = D8.GetComponent<VCC8>().PEight;
		int P82 = S8.GetComponent<VCC8>().PEight;

		P8total = P81 + P82; //同じ種類のカードの合計値を算出

		int D81 = D8.GetComponent<VCC8>().DEight;
		int D82 = S8.GetComponent<VCC8>().DEight;

		D8total = D81 + D82; //同じ種類のカードの合計値を算出
	}
}

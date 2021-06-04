using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count3 : MonoBehaviour
{
	public int P3total;
	public int D3total;
	// Update is called once per frame
	void Update()
	{
		GameObject S3 = transform.Find("S/Cube").gameObject;
		GameObject D3 = transform.Find("D/Cube").gameObject;


		int P31 = D3.GetComponent<VCC3>().PThree;
		int P32 = S3.GetComponent<VCC3>().PThree;

		P3total = P31 + P32; //同じ種類のカードの合計値を算出

		int D31 = D3.GetComponent<VCC3>().DThree;
		int D32 = S3.GetComponent<VCC3>().DThree;

		D3total = D31 + D32; //同じ種類のカードの合計値を算出
	}
}

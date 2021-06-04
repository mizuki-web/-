using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count4 : MonoBehaviour
{
	// Start is called before the first frame update
	public int P4total;
	public int D4total;
	// Update is called once per frame
	void Update()
	{
		GameObject S4 = transform.Find("S/Cube").gameObject;
		GameObject D4 = transform.Find("D/Cube").gameObject;


		int P41 = D4.GetComponent<VCC4>().PFour;
		int P42 = S4.GetComponent<VCC4>().PFour;

		P4total = P41 + P42; //同じ種類のカードの合計値を算出

		int D41 = D4.GetComponent<VCC4>().DFour;
		int D42 = S4.GetComponent<VCC4>().DFour;

		D4total = D41 + D42; //同じ種類のカードの合計値を算出
	}
}

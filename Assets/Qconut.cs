using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qconut : MonoBehaviour
{
	public int PQtotal;
	public int DQtotal;
    // Update is called once per frame
    void Update()
    {
		GameObject SQ = transform.Find("S/Cube").gameObject;
		GameObject DQ = transform.Find("D/Cube").gameObject;

		int PQ1 = DQ.GetComponent<VCCD12>().PTwelve;
		int PQ2 = SQ.GetComponent<VCC12>().PTwelve;

		PQtotal = PQ1 + PQ2; //同じ種類のカードの合計値を算出

		int DQ1 = DQ.GetComponent<VCCD12>().DTwelve;
		int DQ2 = SQ.GetComponent<VCC12>().DTwelve;

		DQtotal = DQ1 + DQ2; //同じ種類のカードの合計値を算出
	}
}

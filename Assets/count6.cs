using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count6 : MonoBehaviour
{
	public int P6total;
	public int D6total;
	// Update is called once per frame
	void Update()
	{
		GameObject S6 = transform.Find("S/Cube").gameObject;
		GameObject D6 = transform.Find("D/Cube").gameObject;


		int P61 = D6.GetComponent<VCC6>().PSix;
		int P62 = S6.GetComponent<VCC6>().PSix;

		P6total = P61 + P62; //同じ種類のカードの合計値を算出

		int D61 = D6.GetComponent<VCC6>().DSix;
		int D62 = S6.GetComponent<VCC6>().DSix;

		D6total = D61 + D62; //同じ種類のカードの合計値を算出
	}

}

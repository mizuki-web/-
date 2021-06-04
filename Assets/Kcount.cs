using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kcount : MonoBehaviour
{
	public int PKtotal;
	public int DKtotal;
	// Start is called before the first frame update
	void Start()
    {
      
	}

    // Update is called once per frame
    void Update()
    {

		GameObject SK = transform.Find("S/13").gameObject;
		GameObject DK = transform.Find("D/13").gameObject;

		int PK1 = DK.GetComponent<VCCD13>().PThirteen;
		int PK2 = SK.GetComponent<VCCS13>().PThirteen;
				 
		PKtotal = PK1 + PK2; //同じ種類のカードの合計値を算出

		int DK1 = DK.GetComponent<VCCD13>().DThirteen;
		int DK2 = SK.GetComponent<VCCS13>().DThirteen;
				
		DKtotal = DK1 + DK2; //同じ種類のカードの合計値を算出
			
		
	}
}

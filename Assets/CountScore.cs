
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
	public GameObject score_object = null;
	public GameObject Dscore_object = null;
	public GameObject ace;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject five;
	public GameObject six;
	public GameObject seven;
	public GameObject eight;
	public GameObject nine;
	public GameObject ten;
	public GameObject Jack;
	public GameObject Queen;
	public GameObject King;

	public int Pcard = 0;
	public int Dcard = 0;
	// Update is called once per frame
	void Update()
	{
		//プレイヤーの手札
		int A = ace.GetComponent<VCC1>().PAce;
		int B = two.GetComponent<VCC2>().PTwo;
		int C = three.GetComponent<VCC3>().PThree;
		int D = four.GetComponent<VCC4>().PFour;
		int E = five.GetComponent<VCC5>().PFive;
		int F = six.GetComponent<VCC6>().PSix;
		int G = seven.GetComponent<VCC7>().PSeven;
		int H = eight.GetComponent<VCC8>().PEight;
		int I = nine.GetComponent<VCC9>().PNine;
		int J = ten.GetComponent<VCC10>().PTen;
		int K = Jack.GetComponent<VCC11>().PEleven;
		int L = Queen.GetComponent<VCC12>().PTwelve;
		int M = King.GetComponent<VCCD13>().PThirteen;
		Pcard = A + B + C + D + E + F + G + H + I + J + K + L + M;
		if (Pcard <= 10　&&　A==1) {
			A = 11;
			Pcard = A + B + C + D + E + F + G + H + I + J + K + L + M;
		}																			

		//ディーラーの手札
		int DA = ace.GetComponent<VCC1>().DAce;
		int DB = two.GetComponent<VCC2>().DTwo;
		int DC = three.GetComponent<VCC3>().DThree;
		int DD = four.GetComponent<VCC4>().DFour;
		int DE = five.GetComponent<VCC5>().DFive;
		int DF = six.GetComponent<VCC6>().DSix;
		int DG = seven.GetComponent<VCC7>().DSeven;
		int DH = eight.GetComponent<VCC8>().DEight;
		int DI = nine.GetComponent<VCC9>().DNine;
		int DJ = ten.GetComponent<VCC10>().DTen;
		int DK = Jack.GetComponent<VCC11>().DEleven;
		int DL = Queen.GetComponent<VCC12>().DTwelve;
		int DM = King.GetComponent<VCCD13>().DThirteen;

		Dcard = DA + DB + DC + DD + DE + DF + DG + DH + DI + DJ + DK + DL + DM ;
		Text score_text = score_object.GetComponent<Text>();
		score_text.text = "Ptotal:" + Pcard;
		Text Dscore_text = Dscore_object.GetComponent<Text>();
		Dscore_text.text = "Dtotal:" + Dcard;
	}
}

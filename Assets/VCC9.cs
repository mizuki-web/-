using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VCC9 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Nine = 0; // スコア変数
	public int PNine = 0;
	public int DNine = 0;
	public GameObject mark;
	// Start is called before the first frame update


	// Update is called once per frame
	void Update()
	{
		if (isInsideCamera)
		{
			Nine = 9;
		}
		else
		{
			Nine = 0;
		}
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PNine = Nine;
			DNine = 0;
		}
		else
		{
			DNine = Nine;
			PNine = 0;

		}

	}
	private void OnBecameInvisible()
	{
		isInsideCamera = false;
	}
	//　カメラ内に入った
	private void OnBecameVisible()
	{
		isInsideCamera = true;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC1 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Ace = 0;
	public int PAce = 0; // プレイヤースコア変数
	public int DAce = 0; // ディーラースコア変数
	public GameObject mark;
	

	//Camera cam;

	void Update()
	{
		//cam = Camera.main;


		if (isInsideCamera)
		{
			Ace = 1; // カメラに映ったら数字を増やす。
		}
		else
		{
			Ace = 0;// カメラに映らなくなったら数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;
		
		if (parent.transform.position.y < mark.transform.position.y)
		{
			PAce = Ace;
			DAce = 0;
		}
		else
		{
			DAce = Ace;
			PAce = 0;

		}

	}
	private void OnBecameInvisible()
	{
		isInsideCamera = false;//　カメラ内から出た
	}

	private void OnBecameVisible()
	{
		isInsideCamera = true;//　カメラ内に入った
	}

}

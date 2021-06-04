
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC11 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Eleven = 0;
	public int PEleven = 0; // プレイヤースコア変数
	public int DEleven = 0; // ディーラースコア変数
	public GameObject mark;
	void Update()
	{
		if (isInsideCamera)
		{
			Eleven = 10; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Eleven = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;

		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PEleven = Eleven;
			DEleven = 0;
		}
		else
		{
			DEleven = Eleven;
			PEleven = 0;

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

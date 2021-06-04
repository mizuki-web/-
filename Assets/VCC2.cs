using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC2 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Two = 0;
	public int PTwo = 0; // プレイヤースコア変数
	public int DTwo = 0; // ディーラースコア変数
	public GameObject mark;
	void Update()
	{
		if (isInsideCamera)
		{
			Two = 2; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Two = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;
		
		if (parent.transform.position.y < mark.transform.position.y)
		{
			PTwo = Two;
			DTwo = 0;
		}
		else
		{
			DTwo = Two;
			PTwo = 0;

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

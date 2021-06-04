using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC5 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Five = 0;
	public int PFive = 0; // プレイヤースコア変数
	public int DFive = 0; // ディーラースコア変数
	public GameObject mark;
	void Update()
	{
		if (isInsideCamera)
		{
			Five = 5; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Five = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PFive = Five;
			DFive = 0;
		}
		else
		{
			DFive = Five;
			PFive = 0;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC10 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Ten = 0;
	public int PTen = 0; // プレイヤースコア変数
	public int DTen = 0; // ディーラースコア変数
	public GameObject mark;
	void Update()
	{
		if (isInsideCamera)
		{
			Ten = 10; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Ten = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y< mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PTen = Ten;
			DTen = 0;
		}
		else
		{
			DTen = Ten;
			PTen = 0;

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

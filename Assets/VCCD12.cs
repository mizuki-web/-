using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCCD12 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Twelve = 0;
	public int PTwelve = 0; // プレイヤースコア変数
	public int DTwelve = 0; // ディーラースコア変数
	public GameObject mark;

    // Update is called once per frame
    void Update()
    {
		if (isInsideCamera)
		{
			Twelve = 10; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Twelve = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PTwelve = Twelve;
			DTwelve = 0;
		}
		else
		{
			DTwelve = Twelve;
			PTwelve = 0;

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

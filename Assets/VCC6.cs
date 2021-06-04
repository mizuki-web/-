using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC6 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Six = 0;
	public int PSix = 0;
	public int DSix = 0;
	public GameObject mark;

	void Update()
	{
		if (isInsideCamera)
		{
			Six = 6; // カメラに見えたら数字を増やす。
		}
		else
		{
			Six = 0;// 見えなくなったら数字を減らす。
		}
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PSix = Six;
			DSix = 0;
		}
		else
		{
			DSix = Six;
			PSix = 0;

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

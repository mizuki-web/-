using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC7 : MonoBehaviour
{
	private bool isInsideCamera;
	public int PSeven = 0; // スコア変数
	public int DSeven = 0; // スコア変数
	public int Seven = 0;
	public GameObject mark;

	// Start is called before the first frame update


	// Update is called once per frame
	void Update()
	{
		if (isInsideCamera)
		{
			Seven = 7;
		}
		else
		{
			Seven = 0;// Qが見えなくなったら12だけ数字を減らす。
		}
		GameObject parent = transform.parent.gameObject;
		if (parent.transform.position.y < mark.transform.position.y)
		{
			PSeven = Seven;
			DSeven = 0;
		}
		else
		{
			DSeven = Seven;
			PSeven = 0;
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

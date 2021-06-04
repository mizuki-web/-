using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;



public class CSVReader : MonoBehaviour
{
	TextAsset csvFile; // CSVファイル
	public GameObject CSV_object = null;
	List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;

	void Start()
	{
		csvFile = Resources.Load("pHit0") as TextAsset; // Resouces下のCSV読み込み
		StringReader reader = new StringReader(csvFile.text);

		// , で分割しつつ一行ずつ読み込み
		// リストに追加していく
		while (reader.Peek() != -1) // reader.Peaekが-1になるまで
		{
			string line = reader.ReadLine(); // 一行ずつ読み込み
			csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
		}

		// csvDatas[行][列]を指定して値を自由に取り出せる
		Debug.Log(csvDatas[1][1]);
		Text CSV_text = CSV_object.GetComponent<Text>();
		CSV_text.text = "CSV:" + (csvDatas[4][1]);
	}

	}

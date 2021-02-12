using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_nouha_obj : MonoBehaviour {

	int meditation=0;
	int attention=0;
	public GameObject Sushi_obj;
	public GameObject Mikan_obj;
	int count_attention=0;
	int count_meditation=0;

	void Start () {
		MindwaveManager.Instance.Controller.OnUpdateMindwaveData += OnUpdateMindwaveData;
	}

	public void OnUpdateMindwaveData(MindwaveDataModel _Data)
	{
		//sensorData = _Data.eSense.attention;
		Debug.Log("nouha meditation : " + _Data.eSense.meditation);
		meditation = _Data.eSense.meditation;
		Debug.Log("nouha attention : " + _Data.eSense.attention);
		attention = _Data.eSense.attention;
	}

	// Update is called once per frame
	void Update () {
		if(attention>90){
			count_attention++;
			if (count_attention > 100) {
				Instantiate (Sushi_obj);
				Debug.Log ("寿司生成");
				count_attention = 0;
			}
		}else{
			count_attention=0;
		}

		if (meditation > 80) {
			count_meditation++;
			if (count_meditation > 100) {
				Instantiate (Mikan_obj);
				Debug.Log ("みかん生成");
				count_meditation = 0;
			}
		} else {
			count_meditation = 0;
		}
		

	}
}

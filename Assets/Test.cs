using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53; //魔力

	//魔力用の関数
	public void Magic() {

		if (mp >= 5) {
			//残りmpを5減らす
			this.mp -= 5;
			//減らした数値分の魔力を表示
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");	

		} else {
			//11回目の時
			Debug.Log("MPが足りないため魔法が使えない");
		}
		
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//配列の初期化
		int[] array = {0, 1, 2, 3, 4,};

		//配列の要素を順番に繰り返す
		for (int i = 0; i < array.Length; i++) {
			//配列の要素を表示する
			//Debug.Log(array [i]);
		}

		//配列の要素を逆順に繰り返す
		for (int i = array.Length - 1; i >= 0; i--) {
			//配列の要素を表示する
			//Debug.Log(array [i]);
		}

		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss(); 
		//Magic関数を１１回繰り返す
		for (int m = 1; m <= 11; m++) {
			lastboss.Magic();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

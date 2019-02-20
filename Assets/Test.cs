using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53; //魔力

	//魔力用の関数
	public void Magic(int energy) {
		//残りMPを減らす
		this.mp -= energy;
		//減らした数値分の魔力を表示
		Debug.Log("魔法攻撃をした。残りMPは" + mp);
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
			Debug.Log(array [i]);
		}

		//配列の要素を逆順に繰り返す
		for (int i = 4; i >= 0; i--) {
			//配列の要素を表示する
			Debug.Log(array [i]);
		}

		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();
		
		//魔法を使う処理を繰り返す
		for (int mp = 53; mp >= 0; mp-=5) {
			if (mp >= 5) {
				//魔法攻撃用の関数を呼び出す
				lastboss.Magic(5);
			} else {
				//mpが５未満の時
				Debug.Log("MPが足りないため魔法が使えない");
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

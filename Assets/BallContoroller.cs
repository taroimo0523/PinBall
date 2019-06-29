using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallContoroller : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

   
    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
   

    //スコアを表示するテキスト
    private GameObject scoreText;
  
    //ScoreTextに表示する変数を初期化
    int score = 0;


    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
       
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //ボールがオブジェクトに衝突したときに点数を表示する
        void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == "SmallStarTag"){
            //小さい星に衝突したとき10点を追加する
            this.score += 10;
            }
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            //小さい雲に衝突したとき30点を追加する
            this.score += 30;
        }
        if (collision.gameObject.tag == "LargeStarTag")
        {
            //大きい星に衝突したとき20点を追加する
            this.score += 20;
        }
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            //大きい雲に衝突したとき100点を追加する
            this.score += 100;
        }
        //ScoreTextに点数を表示
        this.scoreText.GetComponent<Text>().text = this.score.ToString();
    }
    
}
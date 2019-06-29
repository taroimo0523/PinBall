using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoroller : MonoBehaviour {

    //スコアを表示するテキスト
    private GameObject scoreText;
	
    // Use this for initialization
	void Start () {
       
        
    }

    // Update is called once per frame
    void Update() {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStar")
        {
            this.scoreText.GetComponent<Text>().text = "10";
        }



    }
}

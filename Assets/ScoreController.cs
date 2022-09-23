using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // スコアを表示するテキスト
    private GameObject scoreText;

    // ゲーム開始時のスコア
    private int initialScore = 0;
    // 現在のスコア
    private int currentScore;

    // ターゲットSmallStarのポイント
    private int smallStarPoint = 10;
    // ターゲットLargeStarのポイント
    private int largeStarPoint = 20;
    // ターゲットSmallCloudのポイント
    private int smallCloudPoint = 35;
    // ターゲットLargeCloudのポイント
    private int largeCloudPoint = 55;

    // Start is called before the first frame update
    void Start()
    {
        // シーン中のScoreTextを取得
        this.scoreText = GameObject.Find("ScoreText");

        // 現在のスコアとしてゲーム開始時のスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score: " + this.initialScore;

        // 現在のスコアをゲーム開始時のスコアでリセット
        this.currentScore = this.initialScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // 衝突したターゲットのポイント現在のスコアに加算
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.currentScore += this.smallStarPoint;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.currentScore += this.largeStarPoint;
        }
        else if (other.gameObject.tag == "smallCloudTag")
        {
            this.currentScore += this.smallCloudPoint;
        }
        else if (other.gameObject.tag == "largeCloudTag")
        {
            this.currentScore += this.largeCloudPoint;
        }
        // ScoreTextに現在のスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score: " + this.currentScore;
    }
}

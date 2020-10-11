using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;//アウトレット接続で代入するための変数

    // Update is called once per frame
    void Update()
    {
        //画面をタッチするとボールを押した方向に発射する
        if(Input.GetMouseButtonDown(0))
        {
            GameObject ball =
                Instantiate(ballPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            ball.GetComponent<BallController>().Shoot(worldDir.normalized * 2000);
        }
    }
}

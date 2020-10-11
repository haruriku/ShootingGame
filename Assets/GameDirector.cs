using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    public GameObject keeperPrefab;
    float time = 20.0f;
    int point = 0;
    private bool isPose = false;

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    //得点を1加算する
    public void Goal()
    {
        this.point+=1;
    }

    // Update is called once per frame
    void Update()
    {
        //タイムを減らしていく
        this.time -= Time.deltaTime;
        if (time > 0)
        {
            this.timerText.GetComponent<Text>().text =
            this.time.ToString("F1");
            this.pointText.GetComponent<Text>().text =
            this.point.ToString() + " goal";

            //タイムが10秒を切ったらキーパーを増やす
            if (time>=5&&time <= 10)
            {
                Instantiate(keeperPrefab);
            }
        }
        //タイムが0になったらClearSceneに移行する
        else
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}

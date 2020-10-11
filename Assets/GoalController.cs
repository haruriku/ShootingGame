using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    //ゴールにボールが衝突したらGoal()関数を呼び出す
    private void OnCollisionEnter(Collision collision)
    {
        this.director.GetComponent<GameDirector>().Goal();
    }
}

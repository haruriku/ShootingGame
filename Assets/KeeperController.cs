using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperController : MonoBehaviour
{
    float span=0.5f;
    float delta = 0;

    //キーパーを左右にランダムに動かす
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;

            float x = Random.Range(-5, 6);
            transform.position = new Vector3(x,0,4);
        }
    }
}

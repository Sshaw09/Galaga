using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5;
    public int direction = 1;
    public float changeTime = 3.0f;
    public float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        changeTime = timer;

    }

    // Update is called once per frame
    void Update()
    {
        changeTime -= Time.deltaTime;
        Vector2 position = transform.position;
        if (changeTime < 0) {
            direction = -direction;
            changeTime = timer;
        }
            position.x = position.x + Time.deltaTime * speed * direction;
            transform.position = position;
        
    }
}

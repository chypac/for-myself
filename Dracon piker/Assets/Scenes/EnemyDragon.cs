using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDragon : MonoBehaviour
{

    public GameObject dragonEggPrefab ;

    public float speed = 1f;

    public float timeBetweenEggDrops = 1f;

    public float leftRightDistance = 10f;

    public float chanceDirection = 0.1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftRightDistance)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftRightDistance) 
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate() 
    {
        if (Random.value < chanceDirection)
            speed *= -1;
    }
}

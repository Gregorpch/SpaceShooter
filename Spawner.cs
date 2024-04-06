using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Объект который будет создаваться
    public GameObject prefab;
    //Границы 
    public Transform leftBorder;
    public Transform rightBorder;

    //Интервалы спавна
    public float spawnTimer;
    public float spawnInterval = 2;

    

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = spawnInterval;
        }
    }

    public void Spawn()
    {
        //Случайное число по позиции х в диапозоне границ
        float randx = Random.Range(leftBorder.position.x, rightBorder.position.x);

        Vector2 newPos = transform.position;
        newPos.x = randx;
        //Создание копии
        Instantiate(prefab, newPos, Quaternion.identity);
    }
}

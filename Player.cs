using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int Score = 0;

    public GameObject projecTile;

    private float delay = 0;
    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        Move();
    }

    private void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 movePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(movePos);
            transform.position = realPos;
        }
        Attack();
    }
    //Метод атаки
    private void Attack() {
        //Проверка на то что прошло время перезарядки
        if (delay <= 0)
        {
            //Создание копии(что создать,где,Поворот)
            Instantiate(projecTile, transform.position,Quaternion.identity);
            delay = 2;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Скорость перемещения
    public float speed = 2;
    //Эффект
    public GameObject effect;
    //Уничтожение лазера через 10 секунд
    private void Start()
    {
        Destroy(gameObject, 10);
    }

    //Передвижение вверх
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    //Уничтожение соприкоснувшихся объектов
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            //Создание эффекта 
            GameObject effectClone = Instantiate(effect, transform.position, transform.rotation);
            Destroy(effectClone, 2);
            //Уничтожение объектов
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Эффект
    public GameObject effect;

    //множители размеров
    public float minScale = 1.0f;
    public float maxScale = 1.2f;

    public float minRotation = 1.0f;
    public float maxRotation = 1.0f;

    private void Start()
    {
        ScaleAsteroid();
        RotateAsteroid();
    }
    //Столкновение с игроком
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Создание эффекта
            GameObject effectClone = Instantiate(effect, transform.position, transform.rotation);
            Destroy(effectClone, 2);
            //Уничтожение
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    //Измение размеров
    private void ScaleAsteroid()
    {
        float scale = Random.Range(minScale, maxScale);
        transform.localScale = (Vector2)transform.localScale * scale;
    }
    //Изменение поворота
    private void RotateAsteroid()
    {
        float rotate = Random.Range(minRotation,maxRotation);
        transform.localEulerAngles = Vector3.forward * rotate;
    }
}

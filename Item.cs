using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Эффект
    public GameObject effect;

    //Столкновение
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Создание и уничтожение эффекта
            GameObject effectClone = Instantiate(effect, transform.position,transform.rotation);
            Destroy(effectClone, 2);
            //Уничтожение объекта и увеличение счёта
            Destroy(gameObject);
            Player.Score++;
        }
    }
}

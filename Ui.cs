using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Дополнительные пространства имён
using UnityEngine.SceneManagement;
using TMPro;

public class Ui : MonoBehaviour
{
    //Текст счёта
    public TextMeshProUGUI scoreTxt;

    //Окно поражения
    public GameObject loseWindow;

    //Ссылка на экземпляр игрока
    public Player player;

    // Update is called once per frame
    void Update()
    {
        //Счёт переводим в текст
        scoreTxt.text = Player.Score.ToString();
        //Проверка на уничтожение игрока
        if(player == null)
        {
            //Активация окна поражения
            loseWindow.SetActive(true);
        }
    }
    //Метод рестарта сцены
    public void OnRestartClick()
    {
        //Перезапускаем активную сцену
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Player.Score = 0;
    }
}

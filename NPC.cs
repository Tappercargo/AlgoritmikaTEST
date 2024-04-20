using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье
    public float Speed = 1.2f;
    // Уровень
    public float Level = 1;
    // Скорость
    public float health = 5; 
       
    // Start is called before the first frame update
    void Start()
    {
        health = health + Level;
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //Переменая вида Vector3 в которой позиция NPC
        Vector3 newPosition = transform.position;
       //Меняем позицию npc по оси Z согласно скорости npc и времени между кадрами
        newPosition.z += Speed * Time.deltaTime;
        //Меняем позицию npc на новое значение, рассчитанное выше
        transform.position = newPosition;

    }
}

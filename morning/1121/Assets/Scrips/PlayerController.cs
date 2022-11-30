﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float Hinput;
    public float xRange = 15;

    public GameObject foodBullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * Hinput * speed);

        //限制往右邊的移動範圍
        if (transform.position.x >= 15)
        {
            //當玩家向右移動超過等於10的位置時，玩家的位置最右邊只會永遠指定在10
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }

        //限制往左邊的移動範圍
        if (transform.position.x <= -15)
        {
            //當玩家向左移動超過等於10的位置時，玩家的位置最左邊只會永遠指定在-10
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }

        //發射子彈行為
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //讓子彈發射出去
            print("fire！");
            Instantiate(foodBullets, transform.position, foodBullets.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1_3 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("hellow,world!");

        int age = 30, hp = 100, damage = 10, i;

        float height1 = 160.5f, height2;

        string name = "takabe";

        height2 = height1;

        Debug.Log("名前："+name);
        Debug.Log("年齢：" + age);
        Debug.Log("身長：" + height2);


        for (i = 1; i < 20; i++)
        {
            hp -= damage;

            Debug.Log("HP"+hp);
           

            if (hp == 0)
            {
                Debug.Log("あなたは"+i+"回目で死んでしまいました。");
                break;
            }
        }



    }


// Update is called once per frame
    void Update()
    {

    }
}

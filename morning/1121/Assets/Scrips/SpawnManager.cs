using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //宣告一個陣列型態 名為 animalPrefabs 得遊戲物件
    public float randomRangeX = 20;
    public float spawanZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //使用滑鼠左鍵來生成動物
        if(Input.GetMouseButtonDown(0))
        {
            int a_Index = Random.Range(0, animalPrefabs.Length);
            Vector3 spawanPos = new Vector3(Random.Range(-randomRangeX, randomRangeX), 0, spawanZ);

            Instantiate(animalPrefabs[a_Index], spawanPos, animalPrefabs[a_Index].transform.rotation);
        }
    }
}

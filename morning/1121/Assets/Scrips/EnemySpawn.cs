using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] animalPrefab;
    //public int a_Index;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
       if (Input.GetMouseButtonDown(0))
       {

            SpawnRandomAnimal();
            // int a_Index = Random.Range(0, 3);
            //print("���޽�O:" + a_Index);

            //Instantiate(animalPrefab[a_Index], new Vector3(0, 0, 20), animalPrefab[a_Index].transform.rotation);
        }
        
    }

    void SpawnRandomAnimal()
    {
        print("�ʪ����o�I");
        //�H�����Ͷüƪ����ޭ�(0~2)
        int a_Index = Random.Range(0, 3);
        print("���ޭȬO:" + a_Index);

        Vector3 spawnPos = new Vector3(Random.Range(-15, 15), 0, 20);

        //�ͦ��ĤH
        Instantiate(animalPrefab[a_Index], spawnPos, animalPrefab[a_Index].transform.rotation);
    }
}

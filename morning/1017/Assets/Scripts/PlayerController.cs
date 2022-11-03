using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("控制前後速度的數值"), Range(0, 20)]
    public float speed = 20;

    [Header("左右速度")]
    public float trunSpeed = 10;

    [Tooltip("這邊會顯示前後按鍵按下的偵測數值")]
    public float VInput; //宣告一個變量來存放鍵盤按上下鍵時，取得的(正/負)數值
    public float H_Input;

    public float CrazyDrive; //開啟喝醉模式

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VInput = Input.GetAxis("Vertical");//取得鍵盤按上下鍵時，取得的(正/負)數值
        print("前後按鍵" + VInput); //DeBug: 檢查 VInput 中的數值為何

        H_Input = Input.GetAxis("Horizontal");
        print("左右按鍵" + H_Input); //DeBug: 檢查 H_Input 中的數值為何


        //控制車子前後(透過上下鍵, W/S)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VInput);

        CrazyDrive = Random.Range(-30, 30); //設定喝醉的瘋狂數值
        print("CD:" + CrazyDrive);

        //控制車子左右(透過左右鍵, A/D)
        //transform.Translate(Vector3.right * Time.deltaTime * trunSpeed * H_Input);
        transform.Rotate(Vector3.up * Time.deltaTime * trunSpeed * H_Input);
    }
}

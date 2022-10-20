using System.Drawing;
using UnityEngine;

namespace selena
{
    /// <summary>
    /// 20221013
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 註解區域
        //單行註解

        /* 多行註解
         * 多行註解
         * 多行註解
         */

        //A a 不相同的字
        #endregion

        #region 事件區域
        // 喚醒事件:遊戲開始時執行一次
        private void Awake()
        {
            // 輸出(訊息);
            print("Hello"); 
        }

        // 開始事件:Awake 後執行一次
        private void Start()
        {
            print("<color=yellow>開始事件</color>"); 
        }

        // 更新事件:Start 之後執行，執行約 60 FPS
        private void Update()
        {
            print("<color=green>更新事件</color>");
        }
        #endregion
    }
    
}

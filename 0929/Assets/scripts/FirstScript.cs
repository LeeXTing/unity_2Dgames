using System.Drawing;
using UnityEngine;

namespace selena
{
    /// <summary>
    /// 20221013
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѱϰ�
        //������

        /* �h�����
         * �h�����
         * �h�����
         */

        //A a ���ۦP���r
        #endregion

        #region �ƥ�ϰ�
        // ����ƥ�:�C���}�l�ɰ���@��
        private void Awake()
        {
            // ��X(�T��);
            print("Hello"); 
        }

        // �}�l�ƥ�:Awake �����@��
        private void Start()
        {
            print("<color=yellow>�}�l�ƥ�</color>"); 
        }

        // ��s�ƥ�:Start �������A����� 60 FPS
        private void Update()
        {
            print("<color=green>��s�ƥ�</color>");
        }
        #endregion
    }
    
}

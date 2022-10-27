using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>
    
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
    }
}

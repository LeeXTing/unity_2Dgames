using UnityEngine;

namespace Selena
{
    /// <summary>
    /// 2D飛機控制器
    /// </summary>
   public class AirPlaneController2D : MonoBehaviour
   {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite pictureUp;
        [SerializeField] private Sprite pictureMiddle;
        [SerializeField] private Sprite pictureDown;
   }
}

using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// 練習_屬性及回傳
    /// </summary>
    public class homework_07 : MonoBehaviour
    {
        // 當前血量，用來放血量的容器
        [Range(-5f, 100f)]
        public int _hp = 100;
        // 唯讀屬性血量
        public int hp => _hp;

        private void Update()
        {
            if (hp <= 0)
            {
                Debug.Log($"<color=#f00>血量{hp}，角色已死亡");
            }
        }
    }
}


using OLIVER.Class_15;
using UnityEngine;

namespace OLIVER.Class_19.Event
{
    /// <summary>
    /// 背景音樂管理器
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        // 步驟 3. 訂閱事件 (Unity 習慣在 Awake 或 Start 訂閱)
        private void Awake()
        {
            // 事件 : 輸入 += 可以使用 Tab 自動完成 > 命名方法後 > Enter 完成
            class_19_event.onDead += ChangeBgm;
            class_19_event.onDeadAction += ChangeBgmViaHP;
            class_19_event.onEvent += ChangeBgmEvent;
            class_19_event.onEventWithHP += ChangeBgmEventWithHP;
        }

        private void ChangeBgmEventWithHP(object sender, float e)
        {
            LogSystem.LogWithColor($"發送事件者:{sender}, 參數 : {e}", "#ff3");
        }

        private void ChangeBgmEvent(object sender, System.EventArgs e)
        {
            LogSystem.LogWithColor($"發送事件者:{sender}, 參數 : {e}", "#ff3");
        }

        private void ChangeBgmViaHP(string playerName, float hp)
        {
            LogSystem.LogWithColor($"{playerName}, | 血量 : {hp}", "#78f");
            if (hp <= -5) LogSystem.LogWithColor("變更為遊戲結束音樂", "#fdd");
        }

        private void ChangeBgm()
        {
            LogSystem.LogWithColor("變更音樂", "#3f3");
        }
    }
}
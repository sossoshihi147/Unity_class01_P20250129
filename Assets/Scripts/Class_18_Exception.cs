using System;
using UnityEngine;

namespace OLIVER.Class_18
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18_Exception : MonoBehaviour
    {
        private void Awake()
        {
            LogSystem.LogWithColor($"{Division(8, 4)}", "#f33");
            LogSystem.LogWithColor($"{Division(3, 9)}", "#f33");
            LogSystem.LogWithColor($"{Division(7, 0)}", "#f33");

            LogSystem.LogWithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(6)}", "#3f3");

            SetEnemy();
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="numberA">分母</param>
        /// <param name="numberB">分子</param>
        /// <returns></returns>
        /// 允許傳回空值
        private int? Division(int numberA, int numberB)
        {
            // 可能發生例外的區域
            try
            {

                return numberA / numberB;
            }
            // 捕捉到例外為「除以零」時會執行此區域
            catch (DivideByZeroException e)
            {
                // Message 例外官方訊息
                LogSystem.LogWithColor($"分子不能為零 | {e.Message}", "#f99");
                return null;
            }
            // 最後區域
            finally
            {
                LogSystem.LogWithColor("例外處理完畢", "#f73");
            }
        }

        private int[] scores = { 70, 91, 64, 53, 88 };

        private int? GetScores(int index)
        {
            try
            {
            return scores[index];
            }
            catch (DivideByZeroException)
            {
                LogSystem.LogWithColor("發生例外", "#f11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                LogSystem.LogWithColor($"發生例外 | {e.Message}", "#f11");
                return null;
            }
        }

        [SerializeField]
        private GameObject enemy;

        /// <summary>
        /// 設定敵人物件
        /// </summary>
        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true);
            }
            catch (Exception e)
            {
                LogSystem.LogWithColor($"發生例外：{e.Message}", "#f39");
            }
        }
    }
}

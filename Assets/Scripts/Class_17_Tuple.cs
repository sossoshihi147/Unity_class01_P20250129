using System;
using UnityEngine;

namespace OLIVER.Class_17
{
    /// <summary>
    /// 元組
    /// </summary>
    public class Class_17_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            // 元組：儲存多筆不同類型的資料
            // 宣告的方式 1 ：指定類型與名稱
            (string name, int cost, int index) card1 = ("皮卡丘", 1, 7);
            LogSystem.LogWithColor($"{card1.name} | 消耗：{card1.cost} | 編號：{card1.index}", "#f49");
            
            // 宣告的方式 2 ： 指定類型
            (string, int, int) card2 = ("小火龍", 2, 3);
            LogSystem.LogWithColor($"{card2.Item1} | 消耗：{card2.Item2} | 編號：{card2.Item3}", "#4f9");

            // 宣告的方式 3 ： 使用 var
            var card3 = ("妙蛙花", 5, 24);
            LogSystem.LogWithColor($"{card3.Item1} | 消耗：{card3.Item2} | 編號：{card3.Item3}", "#49f");

            // 宣告的方式 4 ： 使用 var 以及指名
            var card4 = (name: "快龍",cost: 6,index: 173);
            LogSystem.LogWithColor($"{card4.name} | 消耗：{card4.cost} | 編號：{card4.index}", "#3f3");

            UseCard(card1);
            UseCard(card4);
            UseCard(("洛奇亞", 8, 199));

            var card1Update = UPdateCardCost(card1);
            LogSystem.LogWithColor($"{card1Update.name} | " +
                $"消耗：{card1Update.cost} | 編號：{card1Update.index}", "#f49");

            LogSystem.LogWithColor($"{card1Update == card1}", "#79f");
            LogSystem.LogWithColor($"{card1Update != card1}", "#79f");
        }

        /// <summary>
        /// 使用卡牌
        /// </summary>
        /// <param name="card">卡牌元組，名稱、消耗與編號</param>
        private void UseCard((string name, int cost, int index) card)
        {
            LogSystem.LogWithColor($"消耗 {card.cost} 使用卡牌：{card.name}", "#ff3");
        }

        private (string name, int cost, int index) UPdateCardCost((string name, int cost, int index) card)
        {
            card.name = card.name + " 降低消耗版本";
            card.cost -= 1;
            return card;
        }
    }
}


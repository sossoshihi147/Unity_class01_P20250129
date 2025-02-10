using UnityEngine;

/// <summary>
/// 練習: 迴圈及陣列
/// </summary>
public class homework_06 : MonoBehaviour
{
    public string[,,] shop =
       {
            //第一頁
            { { "小鋸鱷", "喵喵" , "阿伯怪" } , {"雙彈瓦斯" , "皮卡丘", "果然翁" } },
            //第二頁
            { { "小丑猴", "綠水靈", "菇菇寶貝" } , { "豪豬",  "肥肥", "鋼之肥肥" }  },
            //第三頁
            { { "蓋倫", "卡莎碧雅", "安妮" }  , {"拉克絲" ,  "賈克斯", "傑西" }  }
        };
    private void Start()
    {
        Debug.Log($"<color=#4ed>勇者 {shop[2, 0, 0]} 帶著夥伴 {shop[0, 1, 1]} 去討伐 {shop[1, 0, 2]} </color>");

        //取得第二頁第一排第三個
        Debug.Log($"<color=#0ff>第二頁第一排第三個 : {shop[1, 0, 2]} 已經成為了傳說</color>");
    }
}

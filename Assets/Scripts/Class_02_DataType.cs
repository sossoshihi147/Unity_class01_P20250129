using UnityEngine;
// 三條斜線是摘要 (XML 語言) 用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識 C#資料類型
/// </summary>
public class NewEmptyCSharpScript : MonoBehaviour
{
    //變數語法 :
    //修飾詞 資料類型 變數名稱 指定 預設值;
    //四大常用資料類型
    //整數:儲存沒有小數點的數值 int
    //浮點數:儲存有小數點的數值 float
    //字串:儲存文字，必須使用雙引號 string
    //布林值:儲存正與反 bool 只有兩種值 ture & false
    public int count = 7;
    public float moveSpeed = 3.5f;    //浮點數必須添加 f 後綴
    public float turnSpeed = 30.7F;   //F大小寫皆可
    public string character = "蓋倫";
    public bool isDead = false;       //是否死亡:否
    public bool gameOver = true;      //是否結束:是

}

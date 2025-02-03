using UnityEngine;

/// <summary>
/// 課程 3 : 運算子
/// 補充 : Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_03_Operator : MonoBehaviour
{
    #region 基本的欄位屬性
    // C# 變數 = 欄位 Field
    // 欄位屬性 Field Attritube
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)] : 在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過100")]
    public float moveSpeed = 2.5f;
    //[範圍(最小,最大值)] : 幫助數值類型添加範圍 (面板上改為滑桿)
    [Range(1,100)]
    public byte count = 10;
    //範圍不能使用在非數值類型
    [Range(1, 100)]
    public string weapon = "匕首";
    //[文字範圍(最小行,最大行)] : 使用在字串上，設定面板上文字框範圍
    [TextArea(2,5)]
    public string itemDescription = "這裡是道具描述，這裡是道具描述，這裡是道具描述";

    //多個欄位屬性 (寫法1
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    //多個欄位屬性 (寫法2
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 30.5f;
    // [在屬性面板隱藏] : 將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";
    // [序列化欄位] : 將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    //使用 Unity 事件
    //1. 必須在腳本後面添加 : MonoBehaviour (繼承)
    //2. 使用關鍵字快速完成，例如 : 輸入 Awake 挑選要使用的事件按 Enter
    //(Awake)喚醒事件 : 播放遊戲後會執行的第一個事件，只執行一次
    //事件名稱是藍色的，沒有變色不影響
    private void Awake()
    {
        //將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        //Ctrl + Shift + C 開啟控制台面板
        Debug.Log("哈囉，沃德!! :D");      //輸出文字
        Debug.Log(hp);                    //輸出變數的值  
        Debug.Log("攻擊力 : " + attack);   //輸出字串+變數
        Debug.Log($"攻擊力 : {attack}");   //$字串格式
        Debug.Log("攻擊力 : {attack}");    //沒有寫$ {attack}會被當作字串輸出

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>阿橘</color>");  //輸入顏色
        //色碼: #紅紅綠綠藍藍，數字 : 0~9，a~f 越右邊顏色越亮 #000 黑 ，#fff 白
        Debug.Log("<color=#66aaff>阿藍</color>");  //藍色色碼
        Debug.Log("<color=#6af>阿藍</color>");     //重複色碼可簡寫
    }
}

using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("用來判斷角色是否死亡，true 死亡，false 還沒死亡")]
    public bool dead;
    [Header("剛體")]
    public Rigidbody2D r2d;
    [Header("遊戲管理員")]

    public GameObject goScore, goGM;

    /// <summary>
    /// 小雞跳躍方法。
    /// </summary>
    private void Jump()
    {
        //如果 玩家 按下 左鍵
        //輸入.按下按鍵(左鍵列舉.滑鼠左鍵)(手機觸控)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵");
            r2d.Sleep();
            r2d.gravityScale = 1;  //小機動力=1;
            r2d.AddForce(new Vector2(0, jump));
        }
        
        r2d.SetRotation(10);
    }

    /// <summary>
    /// 小雞死亡方法。
    /// </summary>
    private void Dead()
    {

    }

    //固定偵數 0.002 一頓:要控制物理請寫在只是件內
    private void FixedUpdate()
    {

    }

    //事件:碰撞開始 - 碰撞開始實執行一次
    private void OncollisionEnter2D(Collision2D hit)
    {
        //碰到物件.秀物件.名稱
        print(hit.gameObject.name);

        if (hit.gameObject.name == "地板")
        {
            Dead();
        }
    }
    //事件:處發開始 - 物件必須勾選
    private void OnTriggerEnter2D(Collider2D hit)
    {
        //如果 碰到.物件名稱 為 上 或者 下 - 死亡

    }
}

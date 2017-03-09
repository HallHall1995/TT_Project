////=============================================================================
////
////      ゲームシーンマネージャ [GameSceneManager.cs]
////
////      シングルトンクラス。
////      ゲームの状態を管理します。
////
////      Update : 2016/08/23
////      Author : YutaSaijo
////
////=============================================================================
//using UnityEngine;
//using System.Collections;

//public class GameSceneManager : SingletonMonoBehaviour<GameSceneManager>
//{

//    public enum STATUS
//    {
//        WAIT = 0,
//        START,
//        TUTORIAL,
//        MAIN,
//        RESULT,
//        END,
//        MAX
//    };

//    // Myoを使用するかどうかのチェック
//    public bool use_myo_ = false;

//    // Fanを使用するかどうかのチェック
//    public bool use_fan_ = false;

//    // Controllerを使用するかどうかのチェック
//    public bool use_controller_ = false;

//    // Viverationを使用するかどうかのチェック
//    public bool use_viveration_ = false;

//    // ゲームのステータス
//    public STATUS status_ = STATUS.WAIT;

//    // ゲームの前のステータス
//    private STATUS prev_status_ = STATUS.WAIT;

//    // 各ステータスのトリガー
//    public bool[] status_trigger_;

//    // ステータスが切り替わったかどうか判定用のフラグ
//    private bool status_is_change_ = false;

//    //=========================================================================
//    // 初期化
//    // 全てのオブジェクトのStart()より前に呼ばれます。
//    // 引数：なし
//    // 戻り値：なし
//    //=========================================================================
//    void Awake() {
//        // 
//        // スタートシーンの設定
//        // スタートシーンをゲームシーンに設定します。
//        // 
//        SceneController.Instance.StartScene(STATE_SCENE.SCENE_GAME);

//        // 
//        // 現在のステータスを前回のステータスに代入します。
//        // 
//        prev_status_ = status_;

//        status_trigger_ = new bool[(int)STATUS.MAX];
//        ChangeStatusTrigerReset();

//        // Viverationを設定
//        ViveController.Instance.enabled_ = use_viveration_;

//        // 
//        // チュートリアルから始める場合の処理
//        // 
//        if (status_ == STATUS.TUTORIAL) {
//            AudioManager.Instance.PlayBGM("game_bgm");
//        }
//    }

//    //=========================================================================
//    // 更新
//    // 引数：なし
//    // 戻り値：なし
//    //=========================================================================
//    void Update() {

//        // 
//        // ゲームスタート
//        // 待機状態で入力があった場合、ゲームステータスをSTARTに設定し、ゲームをスタートします。
//        // 
//        if (status_ == STATUS.WAIT) {
//            // 仮
//            if (Input.GetKeyDown(KeyCode.Space)) { 
//                status_ = STATUS.START;
//                GarageProduction.Instance.StartGarageAnimation();
//            }
//        }

//        // 
//        // チュートリアルになった時に行う処理
//        // 
//        if (GetChangeGameStatusTrigger(GameSceneManager.STATUS.TUTORIAL)) {
//            AudioManager.Instance.PlayBGM("game_bgm");
//        }

//        // 
//        // シーン遷移
//        // シーンをゲームシーンに遷移します。
//        // ゲームシーンからゲームシーンへ遷移することで、
//        // ゲームシーンをリセットします。
//        // 
//        if (Input.GetKeyDown(KeyCode.Return) || GetChangeGameStatusTrigger(STATUS.END)) {
//            SceneController.Instance.SetNextScene("game_scene");
//        }

//        // 
//        // ステータスの切り替えが行われていた場合、
//        // ステータス切り替えトリガーフラグをすべてリセットし、
//        // ステータスが切り替わったことを知らせるフラグをOFFにします。
//        // 
//        if (status_is_change_) {
//            ChangeStatusTrigerReset();
//            status_is_change_ = false;
//        }

//        // 
//        // ステータスの切り替え処理
//        // 前回のステータスと今回のステータスが違った場合、
//        // 今回のステータスに切り替わったことを知らせるトリガーフラグをONにします。
//        // 
//        ChangeStatusProcessing();
//    }

//    //=========================================================================
//    // ステータスの切り替え処理
//    // 引数：なし
//    // 戻り値：なし
//    //=========================================================================
//    private void ChangeStatusProcessing() {

//        if (status_ != prev_status_) {
//            status_trigger_[(int)status_] = true;
//            prev_status_ = status_;
//            status_is_change_ = true;
//        }
//    }

//    //=========================================================================
//    // ステータストリガーフラグのリセット
//    // 引数：なし
//    // 戻り値：なし
//    //=========================================================================
//    private void ChangeStatusTrigerReset() {
//        for (int i = 0; i < (int)STATUS.MAX; i++) {
//            status_trigger_[i] = false;
//        }
//    }

//    //=========================================================================
//    // ステータスの切り替え時を取得
//    // 引数：STATUS
//    // 戻り値：bool
//    //=========================================================================
//    public bool GetChangeGameStatusTrigger(STATUS status) {
//        return status_trigger_[(int)status];
//    }
//}

///******************************************************************************/
///*  End Of File                                                               */
///******************************************************************************/
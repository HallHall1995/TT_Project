////=============================================================================
////
////    シーンコントローラー [SceneController.cs]
////
////    Author : YutaSaijo
////    Update : 2015/06/17
////
////=============================================================================
//using UnityEngine;
//using System.Collections;

////*****************************************************************************
//// 列挙型
////*****************************************************************************
//public enum STATE_SCENE
//{
//    SCENE_NONE,
//    SCENE_LOGO,
//    SCENE_TITLE,
//    SCENE_GAME,
//    SCENE_FINISH
//}

////*****************************************************************************
//// エントリポイント [SceneController.cs]
////*****************************************************************************
//public class SceneController : SingletonMonoBehaviour<SceneController>
//{
//    // メンバ変数
//    private     string      m_nextScene;                // 次のシーン名
//    private     Fade        m_fade;                     // フェードオブジェクト
//    private     bool        m_fadeFlag;                 // フェードフラグ
//    private     bool        m_moveSceneFlag;            // シーン遷移フラグ
//    private     STATE_SCENE m_currentScene;             // 現在のシーン
//    private     STATE_SCENE m_prevScene;                // 前回のシーン
//    private     bool        m_finishSceneFlag;

//    // 初期化
//    void Awake()
//    {
//        // 変数初期化
//        m_nextScene         = null;
//        m_fade              = gameObject.AddComponent<Fade>();
//        m_fadeFlag          = false;
//        m_moveSceneFlag     = false;
//        m_prevScene         = STATE_SCENE.SCENE_NONE;
//        m_currentScene      = STATE_SCENE.SCENE_NONE;
//        m_finishSceneFlag   = false;

//        // インスタンスを削除しない設定
//        this.SetDontDestroyOnLoad(true);
//    }


//    // 更新
//    void Update()
//    {
//        // フェード中であれば
//        if (m_fadeFlag == true)
//        {   // フェードオブジェクトがアクティブでなければ
//            if (!m_fade.isActive())
//            {   // 現在のシーンを前回のシーンへ保存
//                m_prevScene = m_currentScene;

//                // 次のシーンを現在のシーンへ保存
//                switch (m_nextScene.ToString())
//                {
//                    case "logo_scene":
//                        m_currentScene = STATE_SCENE.SCENE_LOGO;
//                        break;
//                    case "title_scene":
//                        m_currentScene = STATE_SCENE.SCENE_TITLE;
//                        break;
//                    case "game_scene":
//                        m_currentScene = STATE_SCENE.SCENE_GAME;
//                        break;
//                    default:
//                        m_fadeFlag = false;
//                        return;
//                }
//                // フェードフラグOFF
//                m_fadeFlag = false;

//                // 次のシーンへ遷移する
//                Application.LoadLevel(m_nextScene.ToString());

//                // 次のシーンを空にする
//                m_nextScene = null;
//            }
//        }

//        // シーン遷移フラグがON
//        if (m_moveSceneFlag)
//        {
//            if (!m_fade.isActive() && !m_finishSceneFlag && m_nextScene != null)
//            {
//                if (!m_fadeFlag)
//                {
//                    m_fadeFlag          = true;
//                    m_fade.fade(0.5f, new Color(0.0f, 0.0f, 0.0f, 0.0f), new Color(0.0f, 0.0f, 0.0f, 1.0f), true);
//                    m_moveSceneFlag     = false;
//                    m_finishSceneFlag   = true;
//                }
//            }
//        }
//    }

//    public void StartScene(STATE_SCENE current)
//    {
//        m_currentScene      = current;
//        m_nextScene         = null;

//        // フェードオブジェクトが無ければ関連付ける
//        if (m_fade == null)
//        {
//            m_fade = gameObject.AddComponent<Fade>();
//        }

//        m_fadeFlag          = false;
//        m_fade.fade(1.0f, new Color(0.0f, 0.0f, 0.0f, 1.0f), new Color(0.0f, 0.0f, 0.0f, 0.0f), false);
//        m_finishSceneFlag   = false;
//    }

//    public void SetNextScene(string nextScene)
//    {
//        if (!m_finishSceneFlag)
//        {
//            m_moveSceneFlag = true;
//            m_nextScene     = nextScene;
//        }
//    }

//    public STATE_SCENE GetCurrentScene(){ return m_currentScene; }
//    public STATE_SCENE GetLastScene(){ return m_prevScene; }
//}

///******************************************************************************/
///*  End Of File                                                               */
///******************************************************************************/
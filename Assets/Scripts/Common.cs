﻿//=============================================================================
//
//      共通項目 [Common.cs]
//
//      シングルトンクラス。
//      共通で使用する関数を記述します。
//
//      Update : 2015/10/21
//      Author : YutaSaijo
//
//=============================================================================
using UnityEngine;
using System.Collections;

//public class Common :  SingletonMonoBehaviour<Common> {

//    //=========================================================================
//    // Vector3型ラジアン角の正規化
//    // 第一引数：Vector3型の角度(ラジアン角)
//    // 戻り値：なし
//    //=========================================================================
//    public void NormalizeRadianAngleVector3(ref Vector3 vec) {
//        NormalizeRadianAngle(ref vec.x);
//        NormalizeRadianAngle(ref vec.y);
//        NormalizeRadianAngle(ref vec.z);
//    }

//    //=========================================================================
//    // ラジアン角の正規化
//    // 第一引数：角度(ラジアン角)
//    // 戻り値：なし
//    //=========================================================================
//    public void NormalizeRadianAngle(ref float angle) {
//        if (angle < -Mathf.PI) {
//            angle += Mathf.PI * 2;
//        }
//        else if (angle > Mathf.PI) {
//            angle -= Mathf.PI * 2;
//        }
//    }

//}

/******************************************************************************/
/*  End Of File                                                               */
/******************************************************************************/
﻿/*******************************************************************************
* タイトル   : ステージ用スクリプト
* ファイル名 : stage.cs
* 作成者     : 志賀 麻言
* 作成日     : 2016/08/37
********************************************************************************
* 更新履歴	- 2016/08/37
*			-V0.01 Initial Version
*******************************************************************************/

/*******************************************************************************
* ステートメント設定( 自動リソース開放機能 )
*******************************************************************************/
using UnityEngine;
using System.Collections;


/*******************************************************************************
* クラス設計
*******************************************************************************/
public class StageManager : MonoBehaviour
{
	// ----------------------------------------------------------------------
	// [ メンバ変数 : フィールドに配置するオブジェクトの設定 ]
	// ----------------------------------------------------------------------
	public GameObject NormalTilePrefab;
	public GameObject GimmicCube;
	public GameObject GimmicHammer;
	public GameObject GimmicHammer2;
	public GameObject JumpTile;
	public GameObject FlowTile;
	public GameObject GimmicWheel;
    public GameObject GimmicBun;
    public GameObject LevelUpItem;

    // ----------------------------------------------------------------------
    // [ 列挙型 : フィールドに設置するタイルの種類 ]
    // ----------------------------------------------------------------------
    enum TILE_TYPE
	{
		TILE_TYPE_NONE = 0,				// 0 : 無し
		TILE_TYPE_NORMAL,				// 1 : 普通のタイル
		TILE_TYPE_GIMMIC_CUBE,			// 2 : 飛び出すキューブ
		TILE_TYPE_GIMMIC_HAMMER,        // 3 : 横　ハンマー           ✖使わない
        TILE_TYPE_GIMMIC_HAMMER2,		// 4 : 縦　ハンマー           ✖使わない
		TILE_TYPE_JUMP,					// 5 : ジャンプタイル　→　加速タイルに変化
		TILE_TYPE_FLOW,					// 6 : 落ちるタイル
		TILE_TYPE_WHEEL,				// 7 : ホイール
        TILE_TYPE_BUN,                  // 8 : 文鎮
        TILE_TYPE_ITEM                // 9 : アイテム
    }

	// ----------------------------------------------------------------------
	// [ メンバ変数 : ステージの各種設定 ]
	// ----------------------------------------------------------------------
	const float STAGE_SCALE = 1.75f;	// 大きさ
	const int STAGE_WIDTH = 1;			// 横幅
	const int STAGE_HEIGHT = 1;			// 縦幅
	const int STAGE_X_LINE = 10;		// 2次元配列の X数
	const int STAGE_Z_LINE = 320;        // 2次元配列の X数

	// ----------------------------------------------------------------------
	// [ ステージ1 ]
	// ----------------------------------------------------------------------
	public int[,] GetSatge1()
	{

        int[,] stage_1 = new int[STAGE_Z_LINE, STAGE_X_LINE] {
 {1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,9,1,1,9,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,0,0,1,1,1,1,1,1,1},
{0,0,0,1,1,2,2,2,2,2},
{0,0,0,1,1,1,1,1,1,0},
{0,0,0,1,1,1,9,1,1,0},
{1,1,1,1,1,5,5,5,5,2},
{1,1,1,1,2,1,1,1,1,1},
{1,2,9,1,1,1,1,1,1,1},
{1,1,1,2,1,2,1,1,1,1},
{1,1,1,5,9,1,1,5,1,1},
{1,5,1,2,1,5,1,1,1,1},
{1,1,1,5,1,1,9,1,1,1},
{1,1,1,1,1,5,1,5,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,5,1},
{0,0,0,0,0,0,0,1,1,1},
{1,1,1,1,1,1,0,0,1,1},
{0,0,0,1,1,1,0,0,1,1},
{0,0,0,1,1,1,0,0,1,1},
{0,0,0,2,2,2,0,0,1,1},
{0,0,0,1,1,1,0,0,1,1},
{0,0,0,1,1,1,0,0,1,1},
{0,0,0,1,1,1,1,0,1,1},
{0,0,0,0,1,1,1,0,1,1},
{0,0,0,0,1,9,1,0,1,1},
{0,0,0,0,1,1,1,1,1,1},
{0,0,0,0,1,1,1,1,1,1},
{0,0,0,0,1,1,1,0,0,0},
{0,0,0,0,0,1,1,1,0,0},
{0,0,0,0,0,0,1,1,0,0},
{0,0,0,0,0,0,1,1,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,0,0,0,0,0},
{1,1,1,1,1,1,1,0,0,0},
{1,1,9,1,1,1,1,1,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{2,2,2,2,2,2,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,2,2,2,2,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,0,0},
{0,0,1,1,1,1,1,1,0,0},
{0,0,1,1,1,1,1,1,1,1},
{0,0,0,0,0,1,1,9,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,0,0,0,0,0},
{5,5,5,5,5,5,5,5,5,5},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,0,0,0,0,0,0,0,0,0},
{5,5,5,5,5,5,5,5,5,5},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,0,0,1,1,1,1,1,1,0},
{0,0,0,1,9,1,1,5,5,0},
{0,0,0,1,1,2,1,1,1,0},
{0,0,0,2,1,1,1,1,1,0},
{0,0,1,1,1,1,1,2,1,0},
{0,1,1,1,1,1,1,1,0,0},
{0,1,2,1,9,1,2,1,0,0},
{1,1,1,1,1,1,1,1,0,0},
{1,1,1,1,1,1,1,0,0,0},
{1,1,1,1,2,1,1,1,0,0},
{1,1,1,1,1,1,1,1,1,0},
{1,1,1,1,1,1,1,1,1,0},
{1,1,1,1,1,1,1,1,1,1},
{0,0,0,0,0,0,0,1,1,1},
{0,0,0,0,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,0,1,1,2,2,1,1,0,0},
{0,0,1,1,1,9,1,1,0,0},
{0,0,1,1,1,1,1,1,0,0},
{0,0,1,1,0,0,1,1,0,0},
{0,0,0,0,0,0,0,0,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,5,5,5,5,5,5,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,0,0},
{1,1,1,1,1,9,1,1,0,0},
{1,1,1,1,1,1,1,1,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,0,0,0,0,0,1,1,1,1},
{0,0,0,0,2,2,2,1,1,1},
{0,0,0,0,1,1,1,1,1,1},
{0,0,0,0,1,1,1,1,1,0},
{0,0,0,0,1,1,1,1,1,0},
{0,0,0,0,1,1,0,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{0,0,0,1,1,9,1,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{0,0,0,0,5,5,0,0,0,0},
{0,0,0,0,1,1,0,0,0,0},
{0,0,0,0,1,1,0,0,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,0,0,0},
{1,1,1,1,1,1,0,0,0,0},
{1,1,1,1,1,1,1,0,0,0},
{1,1,1,1,1,1,1,1,0,0},
{1,1,1,1,1,1,1,1,1,0},
{0,1,1,0,0,1,1,1,1,1},
{0,1,1,0,0,0,1,1,1,1},
{0,5,5,0,0,0,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{0,0,0,1,1,1,1,0,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{2,2,2,2,1,1,1,9,1,1},
{2,2,2,2,2,2,1,1,1,1},
{2,2,2,1,1,1,1,1,1,1},
{2,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,0,1,1,1,1,2,2,2,2},
{1,1,1,1,1,1,2,2,0,0},
{1,1,1,1,1,1,2,2,0,0},
{1,1,1,1,1,1,2,2,2,0},
{2,1,1,1,1,2,2,2,2,2},
{1,1,1,1,2,2,2,2,2,2},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,2},
{1,1,1,1,1,1,1,2,2,2},
{1,1,1,1,1,1,1,1,1,2},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,0,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,9,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,0,0,0,0,0,0,0},
{1,1,1,0,0,0,0,0,0,0},
{1,1,1,0,0,0,0,0,0,0},
{1,1,1,0,0,0,0,0,0,0},
{1,1,1,1,1,0,0,0,0,0},
{0,1,1,1,1,1,1,0,0,0},
{0,1,1,1,1,1,1,0,0,0},
{0,0,0,0,1,9,1,0,0,0},
{0,0,0,0,1,1,1,0,0,0},
{0,0,0,0,1,1,1,0,0,0},
{0,0,0,0,0,1,1,0,0,0},
{0,0,0,0,0,1,1,0,0,0},
{0,0,0,0,0,1,1,0,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,2,2},
{1,1,0,0,0,0,0,0,1,1},
{1,1,0,0,0,0,0,1,1,1},
{1,1,0,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,9,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,0,0,0,0,0,5,5,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,9,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,2,2,1,2,2,2,2},
{1,1,1,1,1,1,2,2,2,2},
{0,1,1,1,1,1,2,2,2,2},
{0,0,0,1,1,1,1,1,1,1},
{0,0,0,0,1,1,1,1,1,1},
{0,0,0,0,0,1,1,1,1,1},
{0,0,0,0,0,0,0,1,1,1},
{0,0,0,0,0,0,1,1,1,1},
{0,0,0,0,0,0,1,1,9,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,0,0,0,0,0,0,0},
{1,1,1,1,0,0,0,0,0,0},
{1,1,1,1,1,1,0,0,0,0},
{1,1,1,1,1,1,1,0,0,0},
{1,1,1,1,1,1,1,0,0,0},
{1,1,1,1,1,1,1,1,0,0},
{0,0,0,1,1,1,1,1,1,0},
{0,0,0,1,1,0,1,1,1,1},
{0,0,0,1,1,1,1,1,1,1},
{0,0,0,1,1,1,1,1,1,1},
{0,0,0,1,1,1,1,1,1,1},
{2,2,2,1,1,1,1,2,2,2},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,9,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,2,1,2,9,1,2,2},
{1,1,1,2,1,2,1,1,2,2},
{1,1,1,2,1,2,1,1,2,2},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,2,2,2},
{1,1,1,1,1,1,1,2,1,2},
{1,1,1,1,1,1,1,2,2,2},
{1,9,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,0,0,0,0},
{1,1,1,1,0,0,0,0,0,0},
{1,1,1,1,0,0,0,0,0,0},
{1,1,1,1,0,0,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,2,2,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,0,0},
{1,1,1,2,2,2,1,0,0,0},
{1,1,1,1,1,1,1,1,1,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,9,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,0,1,1,1,1,1},
{1,1,0,0,0,0,1,1,1,1},
{1,1,1,0,0,0,1,1,1,1},
{1,9,1,0,0,0,1,1,1,1},
{1,1,1,1,1,1,1,1,5,1},
{1,1,1,1,1,1,1,5,5,5},
{1,7,7,7,1,1,1,1,1,1},
{1,7,7,7,1,1,1,1,1,1},
{1,1,1,1,1,2,1,1,9,1},
{1,1,1,1,1,1,2,1,1,1},
{1,1,1,1,1,1,1,2,2,2},
{1,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{0,0,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,9,1,1,1,1,1},
{1,1,1,2,2,2,2,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,0,0,1,1,1,1},
{1,1,1,0,0,0,0,1,1,1},
{1,1,1,0,0,0,0,1,1,1},
{1,1,1,0,0,0,0,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{0,1,1,1,1,1,1,1,1,0},
{0,0,1,1,1,1,1,1,0,0},
{0,0,1,1,9,1,1,0,0,0},
{0,1,1,1,1,1,1,1,0,0},
{1,1,1,1,1,1,1,1,1,0},
{1,1,1,1,5,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,5,5,5,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{2,2,2,2,2,1,1,1,1,1},
{2,2,2,2,2,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,9,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,0,0,0,0,0},
{1,1,1,1,0,0,0,0,0,0},
{1,1,1,1,0,0,0,0,0,0},
{1,1,1,1,1,0,0,0,0,0},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
{1,1,1,1,1,1,1,1,1,1},
        };

        return stage_1;
	}

	// ----------------------------------------------------------------------
	// [ 初期化 ]
	// ----------------------------------------------------------------------
	void Start()
	{
		int[,] stage = GetSatge1();
		for (int z = 0; z < STAGE_Z_LINE; z++)
		{
			for (int x = 0; x < STAGE_X_LINE; x++)
			{
				switch ((TILE_TYPE)stage[z, x])
				{
					case TILE_TYPE.TILE_TYPE_GIMMIC_CUBE:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							GimmicCube.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0.5f * STAGE_SCALE, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							GimmicCube.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//GimmicCube.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(GimmicCube, GimmicCube.transform.position, GimmicCube.transform.rotation);
							break;
						}
					case TILE_TYPE.TILE_TYPE_NORMAL:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							NormalTilePrefab.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							NormalTilePrefab.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(NormalTilePrefab, NormalTilePrefab.transform.position, NormalTilePrefab.transform.rotation);
							break;
						}
					case TILE_TYPE.TILE_TYPE_GIMMIC_HAMMER:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							GimmicHammer.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0.5f * STAGE_SCALE, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							GimmicHammer.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//GimmicHammer.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(GimmicHammer, GimmicHammer.transform.position, GimmicHammer.transform.rotation);
							break;
						}
					case TILE_TYPE.TILE_TYPE_GIMMIC_HAMMER2:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							GimmicHammer2.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							GimmicHammer2.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//GimmicHammer.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(GimmicHammer2, GimmicHammer2.transform.position, GimmicHammer2.transform.rotation);
							break;
						}
						case TILE_TYPE.TILE_TYPE_JUMP:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							JumpTile.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							JumpTile.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(JumpTile, JumpTile.transform.position, JumpTile.transform.rotation);
							break;
						}
					case TILE_TYPE.TILE_TYPE_FLOW:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							FlowTile.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							FlowTile.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(FlowTile, FlowTile.transform.position, FlowTile.transform.rotation);
							break;
						}
					case TILE_TYPE.TILE_TYPE_WHEEL:
						{
							float width = STAGE_SCALE;
							float height = STAGE_SCALE;

							GimmicWheel.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0.5f, z * height - (height * (STAGE_Z_LINE - 1)));
							//NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
							GimmicWheel.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
							//NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
							Instantiate(GimmicWheel, GimmicWheel.transform.position, GimmicWheel.transform.rotation);
							break;
						}
                    case TILE_TYPE.TILE_TYPE_BUN:
                        {
                            float width = STAGE_SCALE;
                            float height = STAGE_SCALE;

                            GimmicBun.transform.position = new Vector3( -x * width + ( width * ( STAGE_X_LINE / 2 ) ) , 0.5f , z * height - ( height * ( STAGE_Z_LINE - 1 ) ) );
                            //NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
                            GimmicBun.transform.localScale = new Vector3( STAGE_SCALE , STAGE_SCALE , STAGE_SCALE );
                            //NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
                            Instantiate( GimmicBun , GimmicBun.transform.position , GimmicBun.transform.rotation );
                            break;
                        }
                    case TILE_TYPE.TILE_TYPE_ITEM:
                        {
                            float width = STAGE_SCALE;
                            float height = STAGE_SCALE;
                            

                            LevelUpItem.transform.position = new Vector3(-x * width + (width * (STAGE_X_LINE / 2)), 0, z * height - (height * (STAGE_Z_LINE - 1)));
                            //NormalTilePrefab.transform.rotation = Quaternion.Euler(90, 0, 0); ;
                            LevelUpItem.transform.localScale = new Vector3(STAGE_SCALE, STAGE_SCALE, STAGE_SCALE);
                            //NormalTilePrefab.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
                            Instantiate(LevelUpItem, LevelUpItem.transform.position, LevelUpItem.transform.rotation);
                            break;
                        }
                }
			}
		}
	}
}

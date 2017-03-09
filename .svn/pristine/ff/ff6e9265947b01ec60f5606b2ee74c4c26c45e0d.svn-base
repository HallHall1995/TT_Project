//=============================================================================
//
//      ベジエ曲線 [Bezier.cs]
//
//      Update : 2016/08/27
//      Author : YutaSaijo
//
//=============================================================================
using UnityEngine;
using System.Collections;

// 
// 構造体をInspector上に表示
// クラス内の構造体変数をInspector上に表示します。
// 
[System.Serializable]

public class Bezier : System.Object
{
    public Vector3 p0;
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 p3;

    public float ti = 0f;

    private Vector3 b0 = Vector3.zero;
    private Vector3 b1 = Vector3.zero;
    private Vector3 b2 = Vector3.zero;
    private Vector3 b3 = Vector3.zero;

    private float Ax;
    private float Ay;
    private float Az;

    private float Bx;
    private float By;
    private float Bz;

    private float Cx;
    private float Cy;
    private float Cz;

    public Bezier(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3) {
        this.p0 = v0;
        this.p1 = v1;
        this.p2 = v2;
        this.p3 = v3;
    }

    public Vector3 GetPointAtTime(float t) {
        this.CheckConstant();
        float t2 = t * t;
        float t3 = t * t * t;
        float x = this.Ax * t3 + this.Bx * t2 + this.Cx * t + p0.x;
        float y = this.Ay * t3 + this.By * t2 + this.Cy * t + p0.y;
        float z = this.Az * t3 + this.Bz * t2 + this.Cz * t + p0.z;
        return new Vector3(x, y, z);
    }

    private void SetConstant() {
        this.Cx = 3f * ((this.p0.x + this.p1.x) - this.p0.x);
        this.Bx = 3f * ((this.p3.x + this.p2.x) - (this.p0.x + this.p1.x)) - this.Cx;
        this.Ax = this.p3.x - this.p0.x - this.Cx - this.Bx;

        this.Cy = 3f * ((this.p0.y + this.p1.y) - this.p0.y);
        this.By = 3f * ((this.p3.y + this.p2.y) - (this.p0.y + this.p1.y)) - this.Cy;
        this.Ay = this.p3.y - this.p0.y - this.Cy - this.By;

        this.Cz = 3f * ((this.p0.z + this.p1.z) - this.p0.z);
        this.Bz = 3f * ((this.p3.z + this.p2.z) - (this.p0.z + this.p1.z)) - this.Cz;
        this.Az = this.p3.z - this.p0.z - this.Cz - this.Bz;
    }

    private void CheckConstant() {
        if (this.p0 != this.b0 || this.p1 != this.b1 || this.p2 != this.b2 || this.p3 != this.b3) {
            this.SetConstant();
            this.b0 = this.p0;
            this.b1 = this.p1;
            this.b2 = this.p2;
            this.b3 = this.p3;
        }
    }

    // 速度一定ベジェ
    public Vector3 LinearBezierInterpolate(float nowCnt) {

        // 始点と通常のベジェ曲線を描く点
        Vector3 p, q;
        // 全分割数
        int N = 16;
        // 逆数
        float ni = 1 / (float)N;
        // 区間ごとのt
        float tt = 0;
        // 汎用変数
        float x = nowCnt;
        // 通常のt
        float t = nowCnt;
        // 距離を保持する配列
        float[] dd      = new float[N + 1];

        // 始点を代入
        p = p0;

        // 始めの長さは0
        dd[0] = 0;

        // パラメータに対するベジェ曲線の距離を合算していく
        for(int i = 1; i < N + 1; i++){
            // 時間での区間を進める
            tt += ni;
            // ttでの通常のベジェ曲線上の点を得る

            //q = BezierCurveInterpolate(p0, p1, p2, p3, tt*ts*G, ts*G);
            q = GetPointAtTime(tt);

            // 距離を足し込んで保持
            dd[i] = dd[i-1] + Vector3.Distance(p,q);
            //次の点へ
            p=q;
        }

        // 距離の合計(=dd[N])で正規化
        // これでddはdd[0]=0<dd[1]<dd[2]<...<dd[N-1]<dd[N]=1となる
        for(int i = 1; i < N + 1; i++) {
            dd[i] /= dd[N];
        }

        // 指定されたtが距離でいうと何番目の区間kにあるかを求める
        int k = 0;
        for(int i = 0; i < N; i++ ,k++) {
            if(dd[i]<=t && t<=dd[i+1])break;
        }

        // tが区間内のどのあたりにあるかを調べる
        // t=dd[k]ならx=0,t=dd[k+1]ならx=1,0<=x<=1
        x = (t - dd[k]) / (dd[k+1] - dd[k]);
        // その割合で線形補間し、区間長をかける
        x = (k*(1-x)+(1+k)*x) * ni;

        // 補正
        if (x > 1.0f) { x = 1.0f; }

        // 求めたxに基づいてベジェ曲線上の点を返す
        return GetPointAtTime(x);
    }
}

/******************************************************************************/
/*  End Of File                                                               */
/******************************************************************************/
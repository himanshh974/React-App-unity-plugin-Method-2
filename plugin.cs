using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fuck : MonoBehaviour
{
    // Start is called before the first frame update
    string somestring;
    public void MsgToPlugin()
    {


        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject bridge = new AndroidJavaObject(" com.lop.conne.plugin");
        //AndroidJavaClass bridge = new AndroidJavaClass(" com.lop.conne.plugin");

        bridge.CallStatic("blue");
        //somestring = bridge.Call<string>("blue");
        // Debug.Log(somestring);
    }
}

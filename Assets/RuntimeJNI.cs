using UnityEngine;
using UnityEditor;

public class RuntimeJNI 
{
    public static void endSession()
    {
        AndroidJavaClass jo = new AndroidJavaClass("vn.exp.sdk.track.TrackHelper");
        // jni.FindClass("java.lang.String"); 
        // jni.GetMethodID(classID, "<init>", "(Ljava/lang/String;)V"); 
        // jni.NewStringUTF("some_string"); 
        // jni.NewObject(classID, methodID, javaString); 
        jo.CallStatic("endSession");
        // jni.GetMethodID(classID, "hashCode", "()I"); 
        // jni.CallIntMethod(objectID, methodID);
    }

    public static void purchase(string eventName, string itemName, string quantity, string price)
    {
        AndroidJavaClass jo = new AndroidJavaClass("vn.exp.sdk.track.TrackHelper");
        // jni.FindClass("java.lang.String"); 
        // jni.GetMethodID(classID, "<init>", "(Ljava/lang/String;)V"); 
        // jni.NewStringUTF("some_string"); 
        // jni.NewObject(classID, methodID, javaString); 
        jo.CallStatic("sendEvent", eventName, itemName, quantity, price);
        // jni.GetMethodID(classID, "hashCode", "()I"); 
        // jni.CallIntMethod(objectID, methodID);
    }

    public static void init()
    {

        AndroidJavaClass jo = new AndroidJavaClass("vn.exp.sdk.track.TrackHelper");
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
        jo.CallStatic("init", context, "com.st.st");

        //AndroidJavaObject jo = new AndroidJavaObject("vn/exp/sdk/track/TrackHelper");
        //AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        //AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
        //jo.CallStatic("init", context, "com.st.st");
    }
    
}
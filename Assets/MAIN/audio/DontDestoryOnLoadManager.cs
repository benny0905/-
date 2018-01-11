using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DontDestroyOnLoadManager
{
    static public List<GameObject> Objects = new List<GameObject>();

    public static void DontDestroyOnLoad(this GameObject go) {
       UnityEngine.Object.DontDestroyOnLoad(go);
       Objects.Add(go);
    }

    public static void DestroyAll() {
        foreach(var go in Objects)
            if(go != null)
                UnityEngine.Object.Destroy(go);

        Objects.Clear();
    }
}
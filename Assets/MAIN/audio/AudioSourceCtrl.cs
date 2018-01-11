using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioSourceCtrl : MonoBehaviour {
    public GameObject prefab;

	void Start () {
		if(DontDestroyOnLoadManager.Objects.Count == 0)
        {
            GameObject creation = Instantiate(prefab) as GameObject;
            DontDestroyOnLoadManager.DontDestroyOnLoad(creation);
        }
        else if(DontDestroyOnLoadManager.Objects.Count > 1)
        {
            DontDestroyOnLoadManager.DestroyAll();
            Debug.LogError("FATAL ERROR : 뭔가 이상해!!");
            return;
        }
	}
}

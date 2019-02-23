using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes1: MonoBehaviour {
    public void ChangeScene(string sceneName) { SceneManager.LoadScene("Credits"); }
}

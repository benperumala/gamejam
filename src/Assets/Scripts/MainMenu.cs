using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManager;

public class MainMenu : MonoBehaviour {
    // https://youtu.be/zc8ac_qUXQY

    public void PlayGame() {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }
}

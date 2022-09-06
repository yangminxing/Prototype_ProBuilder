using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System;

[InitializeOnLoad]
public class XPAutoSave 
{
        // Static constructor that gets called when unity fires up.
        static XPAutoSave()
        {
            EditorApplication.playModeStateChanged += (PlayModeStateChange state) => {
                // If we're about to run the scene...
                if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
                {
                    // Save the scene and the assets.
                    Debug.Log("Auto-saving all open scenes...!!!!!! " + state);
                    EditorSceneManager.SaveOpenScenes();
                    AssetDatabase.SaveAssets();
                }
            };
        }

}

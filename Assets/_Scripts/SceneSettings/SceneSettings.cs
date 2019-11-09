using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SceneSettings", menuName ="Scene/Settings")]
[System.Serializable]
public class SceneSettings : ScriptableObject
{
    [Header("SceneConfig")]
    public Scene scene;
    public SoundClip activeSoundClip;

    [Header("Scoreboard configuration")]
    public bool scoreLabelEnabled;
    public bool livesLabelEnabled;

    [Header("Scene Labels")]
    public bool highScoreLabelEnabled;
    public bool startLabelActive;
    public bool endLabelActive;

    [Header("Scene Button")]
    public bool startButtonActive;
    public bool restartButtonActive;
   

}

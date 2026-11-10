using System;
using UnityEngine;

namespace VisualScript.Runtime.AudioPresets
{
    [CreateAssetMenu(
        menuName = "Visual Script/Audio Preset",
        fileName = "New Audio Preset"
    )]

    [Icon("Packages/works.catsoft.visualscript-audio-presets/Editor/Gizmos/GizmoAudioPreset.png")]

    [Serializable]
    public class AudioPreset : Preset
    { }
}

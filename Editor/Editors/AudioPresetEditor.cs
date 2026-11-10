using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using VisualScript.Runtime.AudioPresets;

namespace VisualScript.Editor.AudioPresets
{
    [CustomEditor(typeof(AudioPreset), true)]
    public class AudioPresetEditor : UnityEditor.Editor
    {
        // PAINT METHODS: -------------------------------------------------------------------------

        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();

            SerializedProperty data = this.serializedObject.FindProperty("m_Data");

            root.Add(Space.CreateSmaller());
            root.Add(new PropertyField(data));

            return root;
        }
    }
}
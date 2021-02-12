using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IndiePixel
{
    [CustomEditor(typeof(IP_KeyboardHeli_Input))]
    public class IP_KeyboardHeli_InputEditor : Editor
    {
        #region Variables
        IP_KeyboardHeli_Input targetInput;
        #endregion

        #region Built-in Methods
        private void OnEnable()
        {
            targetInput = (IP_KeyboardHeli_Input)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            DrawDebugUI();
            Repaint();
        }
        #endregion

        #region Custom Methods
        void DrawDebugUI()
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.Space();
            EditorGUI.indentLevel++;
            EditorGUILayout.LabelField("Throttle (-, =): " + targetInput.ThrottleInput.ToString("0.00"));
            EditorGUILayout.LabelField("Collective (up, down): " + targetInput.CollectiveInput.ToString("0.00"));
            EditorGUILayout.LabelField("Cyclic (w, a, s, d): " + targetInput.CyclicInput.ToString("0.00"));
            EditorGUILayout.LabelField("Pedal (left, right): " + targetInput.PedalInput.ToString("0.00")
                
          );
            EditorGUI.indentLevel--;
            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
        }
        #endregion
    }
}

#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/ReskinNormalItem" )]
public class ReskinNormalItem : ScriptableObject
{
    [SerializeField] private SpriteRenderer[] itemNomals;
    [SerializeField] private Sprite[] sprites;

    public void StartReskinNormalItem()
    {
        for (int i = 0; i < Math.Min(itemNomals.Length, sprites.Length); i++)
        {
            itemNomals[i].sprite = sprites[i];
        }
    }
}

[CustomEditor(typeof(ReskinNormalItem))]
public class ReskinNormalItemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ReskinNormalItem data = (ReskinNormalItem)target;

        if (!Application.isPlaying && GUILayout.Button("Reskin"))
        {
            data.StartReskinNormalItem();
        }
    }
}
#endif

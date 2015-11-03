// Credits :
// I got this file from a project located on the Internet
// http://files.unity3d.com/graham/iPhone-Match4.0.zip

using UnityEngine;
using UnityEditor;
using System.Collections;
 
public class TransformCopier : ScriptableObject
{
    private static Vector3 position;
    private static Quaternion rotation;
    private static Vector3 scale;
    
    [MenuItem ("Custom/Transform Copier/Copy Transform &%c")]
    static void DoRecord()
    {
       position = Selection.activeTransform.localPosition;
       rotation = Selection.activeTransform.localRotation;
       scale = Selection.activeTransform.localScale;
    }
 
    [MenuItem ("Custom/Transform Copier/Paste Transform &%v")]
    static void DoApply()
    {
        Selection.activeTransform.localPosition = position;
        Selection.activeTransform.localRotation = rotation;
        Selection.activeTransform.localScale = scale;      
    }
}

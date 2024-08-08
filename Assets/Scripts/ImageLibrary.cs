using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ImageLibrary")]
public class ImageLibrary : ScriptableObject
{
    public ImageItem[] images;

    [System.Serializable]
    public class ImageItem {
        public string name;
        public Sprite image;
    };
}

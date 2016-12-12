using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace Assets.Scripts
{
    public class L5Picture : MonoBehaviour
    {
        public string PictureName;
        public string FileNameInfo;


        public string GetName()
        {
            return PictureName;
        }

        public string ShowPictureInfo()
        {
            return ((TextAsset) Resources.Load(FileNameInfo)).text;
        }
    }
}
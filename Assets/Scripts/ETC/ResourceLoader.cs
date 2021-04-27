using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace HappyBread.ETC
{
    public class ResourceLoader
    {
        public static List<string> LoadText(string fileName)
        {
            TextAsset data = Resources.Load($"Dialogue/{fileName}", typeof(TextAsset)) as TextAsset;
            if (data)
            {
                StringReader sr = new StringReader(data.text);
                List<string> texts = new List<string>();

                string line;
                line = sr.ReadLine();
                while (line != null)
                {
                    texts.Add(line);
                    line = sr.ReadLine();
                }
                return texts;
            }
            return null;
        }

        public static Sprite LoadSprite(string fileName)
        {
            Sprite sprite = Resources.Load($"Image/{fileName}", typeof(Sprite)) as Sprite;
            return sprite;
        }

        public static AudioClip LoadBackgroundAudio(string fileName)
        {
            AudioClip audioClip = Resources.Load($"Audio/Background/{fileName}", typeof(AudioClip)) as AudioClip;
            return audioClip;
        }
        public static string LoadDialogeText(string fileName)
        {
            TextAsset text = Resources.Load($"keywordTextDialoge/{fileName}", typeof(TextAsset)) as TextAsset;
            //을 string으로 리턴해줘야한다. 
            StringReader sr = new StringReader(text.text);
            string texts = sr.ReadLine();
            return texts;
        }
      
    }
}

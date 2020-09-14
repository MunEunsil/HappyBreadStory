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
    }
}

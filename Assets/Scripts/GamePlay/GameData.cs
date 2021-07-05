using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;

namespace HappyBread.GamePlay
{
    [SerializeField]
    public class GameData
    {
        public string PlayerName = DataManager.Instance.PlayerName;
        public List<Evidence> evidences = DataManager.Instance.evidences;
        public int date = DataManager.Instance.date;

        //대화횟수
        public int cake = DataManager.Instance.cake;
        public int choco = DataManager.Instance.choco;
        public int crois = DataManager.Instance.crois;
        public int donut = DataManager.Instance.donut;
        public int hodu = DataManager.Instance.hodu;
        public int jam = DataManager.Instance.jam;
        public int jelly = DataManager.Instance.jelly;
        public int jellyjelly = DataManager.Instance.jellyjelly;
        public int maca = DataManager.Instance.maca;
        public int pancake = DataManager.Instance.pancake;
        public int straw = DataManager.Instance.straw;
        public int twist = DataManager.Instance.twist;


    }
}

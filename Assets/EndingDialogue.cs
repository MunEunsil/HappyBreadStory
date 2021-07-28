using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class EndingDialogue : MonoBehaviour
    {

        //타이핑 효과를 위함
        public Text m_TypingText;
        public string m_Message;
        public float m_Speed = 0.2f;

        public bool printState =false;

        private void Awake()
        {
            m_Message = @"젤리와 젤리젤리는 사실 천연 재료가 아닌 인공 재료로, 어릴 때 많은 차별을 받아왔다. 
하지만 젤리와 젤리젤리는 뛰어난 그림 실력으로 천연재료 가족에 입양되어
고위층에게 그림을 판매할 수 있었고 작가로서. 인정받기 시작했다. 
젤리젤리는 본인의 출신에 대해 창피함을 느끼지 않고, 오히려 차별 없는 세상을 위해 그림을 그렸지만, 
젤리는 본인이 동일한 선상에서 우위를 차지한 채 재료 차별 반대 운동을 하며 자부심을 느꼈다. 첫번째 살빵은 의도치 않게 이뤄졌다. 
돈을 요구하며 천연재료 학교 동기가 아니란 것을 언론에 퍼트리겠다고 협박했기 때문이다. 돈을 준다고 했지만,
인공 재료인 젤리를 비하하며 모욕감을 줘 우발적으로 죽였다. 그 뒤로 하나씩 꼬이기 시작했다. 그렇게 아끼던 동생까지…
나는 이 호텔 연쇄 살빵 사건을 해결하여 많은 상을 받고, 더 유명해졌다.
아, 그리고 크로아상도 이번에 한 건 했다며 승진됐다고 한다… ";
        }
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Typing(m_TypingText,m_Message,m_Speed));
            printState = true;
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator Typing(Text typingText, string message, float speed)
        {
            for (int i = 0; i < message.Length; i++)
            {
                typingText.text = message.Substring(0, i + 1);
                yield return new WaitForSeconds(speed);
            }
            Debug.Log("코루틴 도나?");



        }
        public void printAll()
        {
            StopCoroutine("Typing");
            m_TypingText.text = m_Message;
        }
    }
}

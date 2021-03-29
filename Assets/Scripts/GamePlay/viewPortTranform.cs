using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class viewPortTranform : MonoBehaviour
{
    ScrollRect scrollRect;

    public float posx = 1.3f;
    public float posy = 10.3f;

    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        scrollRect.content.localPosition = new Vector3(posx, posy, 0);

    }

    void SetContentSize()
    {;
        //scrollRect.content를통해서 하이라키뷰에서 봤던 뷰파트 밑의 콘텐츠 게임 오브젝트에 접근할 수 있음 
        // 그리고 size Data를 통해서 높이와 넓이 수정 할 ㅅ ㅜ있음 

       // scrollRect.content.sizeDelta = new Vector2(width,height);
        scrollRect.content.localPosition = new Vector3(posx, posy, 0);
    }
}

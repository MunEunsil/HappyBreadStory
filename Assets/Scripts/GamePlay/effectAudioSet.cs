using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class effectAudioSet : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float sliderVal)
    {
        mixer.SetFloat("em", Mathf.Log10(sliderVal) * 20);
    }//log10을 사용한 이유는 슬라이더 최소 값인 0.0001을 대입하면 -80, 최대값을 대입하면0이 나오기때문
    // 소리의 최저가 -80, 최대가 1이다.
}

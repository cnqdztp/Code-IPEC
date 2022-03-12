using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private bool isPlaying = false;

    public void ToggleVideo()
    {
        if (isPlaying)
        {
            Pause();
        }
        else
        {
            Play();
        }
        isPlaying = !isPlaying;
    }

    void Play()
    {
        gameObject.transform.DOMoveY(1.2f, 1f).SetEase(Ease.InOutElastic);
        GetComponent<VideoPlayer>().Play();
    }
    void Pause()
    {
        gameObject.transform.DOMoveY(-1.2f, 0.5f).SetEase(Ease.InOutElastic);
        GetComponent<VideoPlayer>().Pause();
    }
}

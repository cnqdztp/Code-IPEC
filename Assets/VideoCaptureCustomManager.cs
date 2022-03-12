using System;
using System.Collections;
using System.Collections.Generic;
using Evereal.VideoCapture;
using UnityEngine;

public class VideoCaptureCustomManager : MonoBehaviour
{
    private VideoCapture _videoCapture;
    private bool isCapturing = false;
    private void Awake()
    {
        _videoCapture = GetComponent<VideoCapture>();
    }
    public void ToggleCapture()
    {
        if (isCapturing)
        {
            _videoCapture.StopCapture();
        }
        else
        {
            _videoCapture.StartCapture();
        }
        isCapturing = !isCapturing;
    }
}

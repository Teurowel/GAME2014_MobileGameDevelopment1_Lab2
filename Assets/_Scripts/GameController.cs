using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text sceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detect device orientation
        //if(Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        //{
        //    Debug.Log("Landscape left");
        //}

        //if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        //    Debug.Log("Landscape right");
        //}

        //if (Input.deviceOrientation == DeviceOrientation.Portrait)
        //{
        //    Debug.Log("Portrait");
        //}

        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                //sceneLabel.text = "Landscape left";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349f, -105f);
                break;

            case DeviceOrientation.LandscapeRight:
                //sceneLabel.text = "Landscape right";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490f, -105f);
                break;

            case DeviceOrientation.Portrait:
                //sceneLabel.text = "portriat";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248f, -185f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349f, -185f);
                break;

            case DeviceOrientation.Unknown:
                //sceneLabel.text = "Unknown orientation";
                break;
        }
    }

  
}

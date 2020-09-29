//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TestButtonBehaviour : MonoBehaviour
{
    //public TMP_Text sceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        //SceneManager.LoadScene("End");
        //sceneLabel.text = "test";
        LivesLabel.rectTransform.position = new Vector3(370f, -105f, 0.0f);
        //ScoreLabel.rectTransform.position = new Vector3(-349f, -105f, 0.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector3(-349f, -105f, 0.0f);
    }
}

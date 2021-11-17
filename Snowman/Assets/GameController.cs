using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public UnityEngine.UI.Button BackButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;  
    public void StartGame() 
    {
    this.Message.text = "Can you save the snowman?";
    this.StartButton.gameObject.SetActive(false);
    this.BackButton.gameObject.SetActive(true);
    this.StartScreen.gameObject.SetActive(false);
    this.PlayScreen.gameObject.SetActive(true);
    } 
 
    public void OpenStartScreen()
    {
    this.StartButton.gameObject.SetActive(true);
    this.BackButton.gameObject.SetActive(false);
    this.StartScreen.gameObject.SetActive(true);
    this.PlayScreen.gameObject.SetActive(false);
    }

    public void Start()
    {
    this.StartScreen.gameObject.SetActive(true);
    this.PlayScreen.gameObject.SetActive(false); 
    }
}


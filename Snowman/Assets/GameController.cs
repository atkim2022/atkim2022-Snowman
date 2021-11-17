using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;  
    public void StartGame() 
    {
    this.Message.text = "Can you save the snowman?";
    this.StartButton.gameObject.SetActive(false);
    this.StartScreen.gameObject.SetActive(false);
    this.PlayScreen.gameObject.SetActive(true);
    } 
 
    public void OpenStartScreen()
    {
    this.StartScreen.gameObject.SetActive(true);
    this.PlayScreen.gameObject.SetActive(false);
    }
}


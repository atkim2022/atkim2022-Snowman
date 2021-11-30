using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public UnityEngine.UI.Button BackButton;
    public UnityEngine.UI.Button TryAgainButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text HiddenLetters; 
    public UnityEngine.UI.Text LettersGuessed; 
    public UnityEngine.UI.Text GuessesRemaining;
    public UnityEngine.UI.Text Guess;  
    public UnityEngine.UI.Text AfterGuess;  
    public GameObject LoseScreen;
    public GameObject WinScreen;


    public void StartGame()
    {
        this.guessingGame = new WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        this.Message.text = "Can you save the snowman?";
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
    }

    public void Start()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
    }
    public void Lose()
    {
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(true);
    }

     public void Win()
    {
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
    }


    public void SubmitGuess()
    {
        Debug.Log(this.guessingGame.CheckGuess(PlayerGuess.text));
        Guess.text = PlayerGuess.text;
        HiddenLetters.text = this.guessingGame.GetWord();
        LettersGuessed.text = this.guessingGame.GetGuessedLetters();
        AfterGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        GuessesRemaining.text = $"{this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses()}";
        PlayerGuess.text = string.Empty;
    }
}






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
    public UnityEngine.UI.Button PlayAgainButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text HiddenLetters; 
    public UnityEngine.UI.Text LettersGuessed; 
    public UnityEngine.UI.Text GuessesRemaining;
    public UnityEngine.UI.Text Guess;  
    public UnityEngine.UI.Text AfterGuess;  
    public UnityEngine.UI.Text CorrectWord;  
    public GameObject LoseScreen;
    public GameObject WinScreen;


    public void StartGame()
    {
        WordGuesser.WordSelector mySelector = WordGuesser.WordSelector.LoadFromString("apple banana grape austin pencil book");
        string randomWord = mySelector.GetWord();
        this.guessingGame = new WordGame(randomWord, 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        this.Message.text = "Can you save the snowman?";
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(true);
        HiddenLetters.text = "Word to Guess:";
        LettersGuessed.text = "Letters Guessed:";
        AfterGuess.text = string.Empty;
        GuessesRemaining.text = $"Guesses Remaining: {this.guessingGame.GetGuessLimit()}";
        Guess.text = "Your Guess:";
    }

    public void OpenStartScreen()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
        this.WinScreen.gameObject.SetActive(false);
    }

    public void Start()
    {
        this.StartScreen.gameObject.SetActive(true);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
        this.WinScreen.gameObject.SetActive(false);
    }
    public void Lose()
    {
        CorrectWord.text = $"The correct word was {this.guessingGame.GetFullWord()}";
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(true);
        this.WinScreen.gameObject.SetActive(false);
    }

    public void Win()
    {
        this.StartScreen.gameObject.SetActive(false);
        this.PlayScreen.gameObject.SetActive(false);
        this.LoseScreen.gameObject.SetActive(false);
        this.WinScreen.gameObject.SetActive(true);
    }


    public void SubmitGuess()
    {
        //Debug.Log(this.guessingGame.CheckGuess(PlayerGuess.text));
        AfterGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        Guess.text = $"Your Guess: {PlayerGuess.text}";
        HiddenLetters.text = $"Word to Guess: {this.guessingGame.GetWord()}";
        LettersGuessed.text = $"Letters Guessed: {this.guessingGame.GetGuessedLetters()}";
        GuessesRemaining.text = $"Guesses Remaining: {this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses()}";
        PlayerGuess.text = string.Empty;

        if (this.guessingGame.IsGameOver())
        {
        this.Lose();
        // this.StartScreen.gameObject.SetActive(false);
        // this.PlayScreen.gameObject.SetActive(false);
        // this.LoseScreen.gameObject.SetActive(true);
        // this.WinScreen.gameObject.SetActive(false);
        }

        else if (this.guessingGame.IsGameWon())
        {
        this.Win();
        //this.StartScreen.gameObject.SetActive(false);
        //this.PlayScreen.gameObject.SetActive(false);
        //this.LoseScreen.gameObject.SetActive(false);
        //this.WinScreen.gameObject.SetActive(true);
        }
    }
}






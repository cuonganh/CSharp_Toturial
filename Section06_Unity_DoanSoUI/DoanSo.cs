using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoanSo : MonoBehaviour{
    int min, max;
    int guess;
    public Text guessText;

    void Start(){
        StartGame();
    }

    void StartGame(){
        max = 1000000;
        min = 0;
        NextGuess();
        max = max + 1;
    }

    public void GuessHigher(){
        min = guess;
        NextGuess();
    }

    public void GuessLower(){
        max = guess;
        NextGuess();
    }

    void NextGuess(){
        guess = (max + min)/2;
        // guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}

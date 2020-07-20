using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     
    void Start() merupakan sebuah method/fungsi yang DIJALANKAN PERTAMA KALI ketika script/game dijalankan atau sebelum frame pertama game dijalankan
    method ini biasa disebut inisialisasi pertama sebelum game dijalankan
    void Start() hanya dijalankan sekali saja ketika game dijalankan pertama kali
    
     */

    [SerializeField] int max, min;
    /*[SerializeField] Text textGuess;*/
    [SerializeField] TextMeshProUGUI textGuess;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        nextGuess();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void nextGuess()
    {
        guess = Random.Range(min, max + 1);
        displayGuess();
    }

    public void onPressHigher()
    {
        min = guess + 1;
        nextGuess();
    }

    public void onPressLower()
    {
        max = guess - 1;
        nextGuess();
    }
    
    public void displayGuess()
    {
        textGuess.text = guess.ToString();
    }
}

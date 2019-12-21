using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoanSo : MonoBehaviour{
    int min, max;
    int guess;

    // Start is called before the first frame update
    void Start(){
        StartGame();
    }

    void StartGame(){
        int min = 0;
        int max = 100;
        guess = (max + min)/2;

        print("==================== Game Đoán Số v1.0 ====================");
        print("Chào mừng đến với game đến số v1.0");
        print("Hãy nghĩ về một số và nhớ nó nhưng không nói ra");
        print("Bạn có thể chọn số từ " + min + " đến " + max);

        print("Số bạn chọn bé hơn " + guess + " nhấn xuống, lớn hơn nhấn lên, bằng nhấn Enter");

        max += 1;
    }

    // Update is called once per frame
    void Update(){
        NextGame();    
    }  

    void NextGame(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NextGuess();
            print("Ban vua nhan len.");
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NextGuess();
            print("Ban vua nhan xuong");
        }else if(Input.GetKeyDown(KeyCode.Return)){
            print("Số bạn chọn là " + guess);
            
            Start();
        }
    }

    void NextGuess(){
        guess = (max + min)/2;

        print("Số bạn chọn bé hơn hay lớn hơn " + guess);
    }
}

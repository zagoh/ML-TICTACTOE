using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI_Turn : MonoBehaviour
{

    public int turn;


    public Sprite[] sprites; //shapes to be placed on the empty spaces//
    public string[] posNames;
    Sprite originalSprite; 
    Sprite currSprite; //current sprite that is being used//

    

    
    List<string> pattern = new List<string>(new string[9]); //A list to collect the shapes to check for win or lose//
    public int count; //count how many steps were taken and check if it is a draw//


    public minimax_AI ai;
    int w;


    public Text endText; //when somebody wins//
    List<Image> images = new List<Image>();

    private void Start()
    {

        for (int i = 0; i < pattern.Count; i++)
        {
            pattern[i] = ""; //set the spaces to blank//
        }

        //To random choose who to start first//
        turn = Random.Range(1,2);

        if(turn == 1)
        {
            currSprite = sprites[1];

        }
        else if(turn == 2)
        {
            currSprite = sprites[0];

        }

    }
    
    //change to the next player//
    public void TurnChange()
    {
        if(currSprite == sprites[0])
        {
            //User's turn//
            currSprite = sprites[1];
            turn = 2;
        }
        else if(currSprite == sprites[1])
        {
            //Computer's turn//
            currSprite = sprites[0];
            turn = 1;
            SelectPosition(ResultPosition(posNames));
            
            
        }
    }

    //return the position name of the next step where to computer wants to take//
    public string ResultPosition(string[] strings)
    {
        w = 0;
        string[,] currBoard = new string[3, 3];


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                currBoard[i, j] = strings[w];

                w++;
            }
        }

        int[] position = ai.Count();
       
        return currBoard[position[0],position[1]];
    }

    //give the computer the current status of the board//
    public char[,] ReadBoard()
    {
        w = 0;
        char[,] currBoard = new char[3, 3];


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                if (pattern[w] == "X")
                {
                    currBoard[i, j] = 'X';
                }
                else if (pattern[w] == "O")
                {
                    currBoard[i, j] = 'O';
                }
                else
                {
                    currBoard[i, j] = '_';
                }

                w++;
                Debug.Log(currBoard[i, j]);
            }
        }
        
        return currBoard;
    }


    //When user or computer has given their input to the place they want to select//
    public void SelectPosition(string posName)
    {
        Image selPos = GameObject.Find(posName).transform.GetChild(0).GetComponent<Image>();

        if (images.Contains(selPos))
        {
            //Check is there is double selection of the position selected//
            Debug.LogError("double click");
        } 

        images.Add(selPos);
        originalSprite = selPos.sprite;

        if(selPos.sprite.name == "UISprite") //check if the selected position has been selected before
        {
            selPos.sprite = currSprite; //place user's or computer's shape to the selected position//
            selPos.color = new Color(1, 1, 1, 1);

            //store the selected position and the shape into the list
            if(posName == "TL")
            {
                pattern[0] = currSprite.name;
            }
            if (posName == "TM")
            {
                pattern[1] = currSprite.name;
            }
            if (posName == "TR")
            {
                pattern[2] = currSprite.name;
            }
            if (posName == "ML")
            {
                pattern[3] = currSprite.name;
            }
            if (posName == "MM")
            {
                pattern[4] = currSprite.name;
            }
            if (posName == "MR")
            {
                pattern[5] = currSprite.name;
            }
            if (posName == "BL")
            {
                pattern[6] = currSprite.name;
            }
            if (posName == "BM")
            {
                pattern[7] = currSprite.name;
            }
            if (posName == "BR")
            {
                pattern[8] = currSprite.name;
            }



            CheckWin(); //check if there is anyone that has won the game after every turn//

        }
        
    }


    //check if there is anyone that has won the game after every turn//
    private void CheckWin()
    {
        if( //these are the conditions for winning//
            (pattern[0] == pattern[1] && pattern[0] == pattern[2]) && pattern[0] != "" ||
            (pattern[3] == pattern[4] && pattern[3] == pattern[5]) && pattern[3] != "" ||
            (pattern[6] == pattern[7] && pattern[6] == pattern[8]) && pattern[6] != "" ||
            (pattern[0] == pattern[3] && pattern[0] == pattern[6]) && pattern[0] != "" ||
            (pattern[1] == pattern[4] && pattern[1] == pattern[7]) && pattern[1] != "" ||
            (pattern[2] == pattern[5] && pattern[2] == pattern[8]) && pattern[2] != "" ||
            (pattern[0] == pattern[4] && pattern[0] == pattern[8]) && pattern[0] != "" ||
            (pattern[2] == pattern[4] && pattern[2] == pattern[6]) && pattern[2] != "")
        {
            endText.gameObject.SetActive(true);
            if(turn == 2)
            {
                //user is the winner//
                endText.text = "O is the winner";
            }
            if(turn == 1)
            {
                //computer is the winner//
                endText.text = "X is the winner";
            }
            StartCoroutine(Reset());
        }

        else
        {
            
            if(count == 8)
            {
                //when all the spaces has been filled and there is no winner//
                endText.gameObject.SetActive(true);
                endText.text = "there is no winner";
                StartCoroutine(Reset());

            }
            else if(count <8)
            {
                count++;
                TurnChange();//change to the next player//
            }

        }
    }


    //restart the game//
    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(1.5f);
        for (int a = 0; a < images.Count; a++)
        {
            images[a].color = new Color(1, 1, 1, 0);
            images[a].sprite = originalSprite;
            
            yield return null;
        }
        for(int i = 0; i < pattern.Count ; i++)
        {
            pattern[i] = "";
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        endText.gameObject.SetActive(false);
        images.Clear();
        count = 0;
        yield return new WaitForSeconds(0.1f);
        TurnChange();
        
    }


}

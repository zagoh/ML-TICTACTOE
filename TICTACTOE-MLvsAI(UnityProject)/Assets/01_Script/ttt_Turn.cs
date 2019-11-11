using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAgents;

public class ttt_Turn : MonoBehaviour
{

    public int turn;

    public Sprite[] sprites; //shapes to be placed on the empty spaces//
    Sprite originalSprite;
    Sprite currSprite; //current sprite that is being used//


    public ttt_Agent[] agents; //mlagents of player A and B
    public bool playerA;
    public bool playerB;

    public Text endText; //when somebody wins//
    List<Image> images = new List<Image>();

    private void Start()
    {
        //To random choose who to start first//
        turn = Random.Range(1, 2);

        if(turn == 1)
        {
            currSprite = sprites[0];
            playerA = true;
            playerB = false;
        }
        else if(turn == 2)
        {
            currSprite = sprites[1];
            playerB = true;
            playerA = false;
        }

    }

    //change to the next player//
    public void TurnChange()
    {
        
        if(currSprite == sprites[0])
        {
            //user's turn//
            currSprite = sprites[1];
            turn = 2;
            playerB = true;
            playerA = false;
        }
        else if(currSprite == sprites[1])
        {
            //computer's turn//
            currSprite = sprites[0];
            turn = 1;
            playerA = true;
            playerB = false;
        }
    }

    //When user or computer has given their input to the place they want to select//
    public void SelectPosition(string posName)
    {
        Image selPos = GameObject.Find(posName).transform.GetChild(0).GetComponent<Image>();
        if (images.Contains(selPos))
        {
            Debug.LogError("double click");
        }
        images.Add(selPos);
        originalSprite = selPos.sprite;
        if(selPos.sprite.name == "UISprite") //check if the selected position has been selected before
        {
            selPos.sprite = currSprite; //place current shape to the selected position//
            selPos.color = new Color(1, 1, 1, 1);

            //store the selected position and the shape into the list
            if(posName == "TL")
            {
                pattern[0] = turn;
            }
            if (posName == "TM")
            {
                pattern[1] = turn;
            }
            if (posName == "TR")
            {
                pattern[2] = turn;
            }
            if (posName == "ML")
            {
                pattern[3] = turn;
            }
            if (posName == "MM")
            {
                pattern[4] = turn;
            }
            if (posName == "MR")
            {
                pattern[5] = turn;
            }
            if (posName == "BL")
            {
                pattern[6] = turn;
            }
            if (posName == "BM")
            {
                pattern[7] = turn;
            }
            if (posName == "BR")
            {
                pattern[8] = turn;
            }



            CheckWin(); //check if there is anyone that has won the game after every turn//
            
        }
        
    }

    //A list to collect the shapes to check for win or lose//
    List<int> pattern = new List<int>(new int[9]);
    public int count;

    private void CheckWin()
    {
        if( //these are the conditions for winning//
            (pattern[0] == pattern[1] && pattern[0] == pattern[2]) && pattern[0] != 0 ||
            (pattern[3] == pattern[4] && pattern[3] == pattern[5]) && pattern[3] != 0 ||
            (pattern[6] == pattern[7] && pattern[6] == pattern[8]) && pattern[6] != 0 ||
            (pattern[0] == pattern[3] && pattern[0] == pattern[6]) && pattern[0] != 0 ||
            (pattern[1] == pattern[4] && pattern[1] == pattern[7]) && pattern[1] != 0 ||
            (pattern[2] == pattern[5] && pattern[2] == pattern[8]) && pattern[2] != 0 ||
            (pattern[0] == pattern[4] && pattern[0] == pattern[8]) && pattern[0] != 0 ||
            (pattern[2] == pattern[4] && pattern[2] == pattern[6]) && pattern[2] != 0  )
        {
            endText.gameObject.SetActive(true);
            if(turn == 2)
            {
                //When computer wins//
                agents[1].AddReward(0.4f);
                agents[0].AddReward(-0.2f);
                endText.text = "X is the winner";
            }
            if(turn == 1)
            {
                //When user wins//
                agents[0].AddReward(0.4f);
                agents[1].AddReward(-0.2f);
                endText.text = "O is the winner";
            }
            Invoke("Reset", 1.5f);
        }

        else
        {
            
            if(count == 8)
            {
                //When it is a draw//
                endText.gameObject.SetActive(true);
                endText.text = "there is no winner";
                agents[0].AddReward(0.25f);
                agents[1].AddReward(0.25f);
                Invoke("Reset", 1.5f);

            }
            else if(count <8)
            {
                count++;
                TurnChange();//change to the next player//
            }

        }
    }

    //restart the game//
    public void Reset()
    {
        for(int i = 0; i < pattern.Count; i++)
        {
            pattern[i] = 0;
        }
        for(int a = 0; a< images.Count; a++)
        {
            images[a].color = new Color(1, 1, 1, 0);
            images[a].sprite = originalSprite;
            
        }
        images.Clear();
        endText.gameObject.SetActive(false);
        agents[0].AgentReset();
        agents[1].AgentReset();
        TurnChange();
        count = 0;
        Debug.Log("Reset done");
    }


}

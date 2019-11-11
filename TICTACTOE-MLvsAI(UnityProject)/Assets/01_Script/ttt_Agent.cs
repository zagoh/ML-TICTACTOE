using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;
using UnityEngine.UI;

public class ttt_Agent : Agent
{
    //public Button[] spaces;
    public List<Button> spaces;
    public List<Image> tempSpaces;
    public ttt_Turn controlScript;


    public override void CollectObservations()
    {
        AddVectorObs(tempSpaces[0]);
        AddVectorObs(tempSpaces[1]);
        AddVectorObs(tempSpaces[2]);
        AddVectorObs(tempSpaces[3]);
        AddVectorObs(tempSpaces[4]);
        AddVectorObs(tempSpaces[5]);
        AddVectorObs(tempSpaces[6]);
        AddVectorObs(tempSpaces[7]);
        AddVectorObs(tempSpaces[8]);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        if (this.name == "Agent A" && controlScript.playerA == true)
        {
            if (tempSpaces[0].sprite == tempSpaces[1].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
            {
                spaces[2].onClick.Invoke();
                controlScript.playerA = false;

            }
            else if (tempSpaces[1].sprite == tempSpaces[2].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
            {
                spaces[0].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[0].sprite == tempSpaces[2].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[1].sprite.name == "UISprite")
            {
                spaces[1].onClick.Invoke();
                controlScript.playerA = false;
            }


            else if (tempSpaces[3].sprite == tempSpaces[4].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[5].sprite.name == "UISprite")
            {
                spaces[5].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[3].sprite == tempSpaces[5].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
            {
                spaces[4].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[5].sprite == tempSpaces[4].sprite && (tempSpaces[5].sprite.name == "O" || tempSpaces[5].sprite.name == "X") && tempSpaces[3].sprite.name == "UISprite")
            {
                spaces[3].onClick.Invoke();
                controlScript.playerA = false;
            }


            else if (tempSpaces[6].sprite == tempSpaces[7].sprite && (tempSpaces[6].sprite.name == "O" || tempSpaces[6].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
            {
                spaces[8].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[6].sprite == tempSpaces[8].sprite && (tempSpaces[6].sprite.name == "O" || tempSpaces[6].sprite.name == "X") && tempSpaces[7].sprite.name == "UISprite")
            {
                spaces[7].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[7].sprite == tempSpaces[8].sprite && (tempSpaces[7].sprite.name == "O" || tempSpaces[7].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
            {
                spaces[6].onClick.Invoke();
                controlScript.playerA = false;
            }

            else if (tempSpaces[0].sprite == tempSpaces[3].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
            {
                spaces[6].onClick.Invoke();
                controlScript.playerA = false;

            }
            else if (tempSpaces[0].sprite == tempSpaces[6].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[3].sprite.name == "UISprite")
            {
                spaces[3].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[3].sprite == tempSpaces[6].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
            {
                spaces[0].onClick.Invoke();
                controlScript.playerA = false;
            }


            else if (tempSpaces[1].sprite == tempSpaces[4].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[7].sprite.name == "UISprite")
            {
                spaces[7].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[1].sprite == tempSpaces[7].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
            {
                spaces[4].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[4].sprite == tempSpaces[7].sprite && (tempSpaces[4].sprite.name == "O" || tempSpaces[4].sprite.name == "X") && tempSpaces[1].sprite.name == "UISprite")
            {
                spaces[1].onClick.Invoke();
                controlScript.playerA = false;
            }


            else if (tempSpaces[2].sprite == tempSpaces[5].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
            {
                spaces[8].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[2].sprite == tempSpaces[8].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[5].sprite.name == "UISprite")
            {
                spaces[5].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[5].sprite == tempSpaces[8].sprite && (tempSpaces[5].sprite.name == "O" || tempSpaces[5].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
            {
                spaces[2].onClick.Invoke();
                controlScript.playerA = false;
            }

            else if (tempSpaces[0].sprite == tempSpaces[4].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
            {
                spaces[8].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[8].sprite == tempSpaces[4].sprite && (tempSpaces[8].sprite.name == "O" || tempSpaces[8].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
            {
                spaces[0].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[0].sprite == tempSpaces[8].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
            {
                spaces[4].onClick.Invoke();
                controlScript.playerA = false;
            }

            else if (tempSpaces[2].sprite == tempSpaces[4].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
            {
                spaces[6].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[2].sprite == tempSpaces[6].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
            {
                spaces[4].onClick.Invoke();
                controlScript.playerA = false;
            }
            else if (tempSpaces[4].sprite == tempSpaces[6].sprite && (tempSpaces[4].sprite.name == "O" || tempSpaces[4].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
            {
                spaces[2].onClick.Invoke();
                controlScript.playerA = false;
            }
            else
            {
                ChooseSpaceA(vectorAction);
            }


        }
        if (this.name == "Agent B" && controlScript.playerB == true)
        {
            if (this.name == "Agent B" && controlScript.playerB == true)
            {
                if (tempSpaces[0].sprite == tempSpaces[1].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
                {
                    spaces[2].onClick.Invoke();
                    controlScript.playerB = false;

                }
                else if (tempSpaces[1].sprite == tempSpaces[2].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
                {
                    spaces[0].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[0].sprite == tempSpaces[2].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[1].sprite.name == "UISprite")
                {
                    spaces[1].onClick.Invoke();
                    controlScript.playerB = false;
                }


                else if (tempSpaces[3].sprite == tempSpaces[4].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[5].sprite.name == "UISprite")
                {
                    spaces[5].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[3].sprite == tempSpaces[5].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
                {
                    spaces[4].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[5].sprite == tempSpaces[4].sprite && (tempSpaces[5].sprite.name == "O" || tempSpaces[5].sprite.name == "X") && tempSpaces[3].sprite.name == "UISprite")
                {
                    spaces[3].onClick.Invoke();
                    controlScript.playerB = false;
                }


                else if (tempSpaces[6].sprite == tempSpaces[7].sprite && (tempSpaces[6].sprite.name == "O" || tempSpaces[6].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
                {
                    spaces[8].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[6].sprite == tempSpaces[8].sprite && (tempSpaces[6].sprite.name == "O" || tempSpaces[6].sprite.name == "X") && tempSpaces[7].sprite.name == "UISprite")
                {
                    spaces[7].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[7].sprite == tempSpaces[8].sprite && (tempSpaces[7].sprite.name == "O" || tempSpaces[7].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
                {
                    spaces[6].onClick.Invoke();
                    controlScript.playerB = false;
                }

                else if (tempSpaces[0].sprite == tempSpaces[3].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
                {
                    spaces[6].onClick.Invoke();
                    controlScript.playerB = false;

                }
                else if (tempSpaces[0].sprite == tempSpaces[6].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[3].sprite.name == "UISprite")
                {
                    spaces[3].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[3].sprite == tempSpaces[6].sprite && (tempSpaces[3].sprite.name == "O" || tempSpaces[3].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
                {
                    spaces[0].onClick.Invoke();
                    controlScript.playerB = false;
                }


                else if (tempSpaces[1].sprite == tempSpaces[4].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[7].sprite.name == "UISprite")
                {
                    spaces[7].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[1].sprite == tempSpaces[7].sprite && (tempSpaces[1].sprite.name == "O" || tempSpaces[1].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
                {
                    spaces[4].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[4].sprite == tempSpaces[7].sprite && (tempSpaces[4].sprite.name == "O" || tempSpaces[4].sprite.name == "X") && tempSpaces[1].sprite.name == "UISprite")
                {
                    spaces[1].onClick.Invoke();
                    controlScript.playerB = false;
                }


                else if (tempSpaces[2].sprite == tempSpaces[5].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
                {
                    spaces[8].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[2].sprite == tempSpaces[8].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[5].sprite.name == "UISprite")
                {
                    spaces[5].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[5].sprite == tempSpaces[8].sprite && (tempSpaces[5].sprite.name == "O" || tempSpaces[5].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
                {
                    spaces[2].onClick.Invoke();
                    controlScript.playerB = false;
                }

                else if (tempSpaces[0].sprite == tempSpaces[4].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[8].sprite.name == "UISprite")
                {
                    spaces[8].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[8].sprite == tempSpaces[4].sprite && (tempSpaces[8].sprite.name == "O" || tempSpaces[8].sprite.name == "X") && tempSpaces[0].sprite.name == "UISprite")
                {
                    spaces[0].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[0].sprite == tempSpaces[8].sprite && (tempSpaces[0].sprite.name == "O" || tempSpaces[0].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
                {
                    spaces[4].onClick.Invoke();
                    controlScript.playerB = false;
                }

                else if (tempSpaces[2].sprite == tempSpaces[4].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[6].sprite.name == "UISprite")
                {
                    spaces[6].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[2].sprite == tempSpaces[6].sprite && (tempSpaces[2].sprite.name == "O" || tempSpaces[2].sprite.name == "X") && tempSpaces[4].sprite.name == "UISprite")
                {
                    spaces[4].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else if (tempSpaces[4].sprite == tempSpaces[6].sprite && (tempSpaces[4].sprite.name == "O" || tempSpaces[4].sprite.name == "X") && tempSpaces[2].sprite.name == "UISprite")
                {
                    spaces[2].onClick.Invoke();
                    controlScript.playerB = false;
                }
                else
                {
                    ChooseSpaceB(vectorAction);
                }

            }
        }
    }

    public void ChooseSpaceA(float[] act)
    {      
        int value = Mathf.FloorToInt(act[0]);
        if (tempSpaces[value].sprite.name == "UISprite")
        {
            spaces[value].onClick.Invoke();
            controlScript.playerA = false;
        }
    }
      

    public void ChooseSpaceB(float[] act)
    {
        int value = Mathf.FloorToInt(act[0]);
        if (tempSpaces[value].sprite.name == "UISprite")
            {
                spaces[value].onClick.Invoke();
                controlScript.playerB = false;
            } 

    }

    public override void AgentReset()
    {
        base.AgentReset();
    }

}

# ML-TICTACTOE
Unity3D ml-agents for TIC TAC TOE


Introduction:
2 types of methods for TIC-TAC-TOE were developed.
One of them is made using **machine-learning** , while the other is made using **minimax algorithm**.
The games are developed using Unity3D programs.



Playing the Game:
User will be using &quot;O&quot; while computer uses &quot;X&quot;. Simply start by clicking on of the position in the Tic-Tac-Toe.



Explanation:

Machine-Learning Program:

**ttt_Turn.cs** is the control script where the main operation takes place.

**ttt_Agent.cs** is the script that controls the computer.

Unity ml-agents were used for this project.
The decision made by the computer is done by a mixture of hard-code and machine-learning. The hard-coding remove the obvious winning possibilities such as:

| X | X |   |
| --- | --- | --- |
|   | O |   |
|   |   |   |

| X |   |   |
| --- | --- | --- |
| X | O |   |
|   |   |   |

Two horizontal or vertical spots has been chosen by the user. Hence, the next place the computer should choose is the top right box.



|   |   |   |
| --- | --- | --- |
|   | X | O |
| X |   |   |

| X |   |   |
| --- | --- | --- |
|     | X |   |
|   | O |   |

Or when two diagonal spots has been chosen.
Once these options are in place, the rest of the options are decided by machine-learning using ML-agents. The ML-agents was trained by running 1e5 steps estimated to be around 1 hour. However, due to the possibilities of repeating the steps, it is not yet enough for the machine to learn the correct moves entirely. As a result, this method will have a chance of the computer losing to the user.



Minimax Algorithm Program:

**AI_Turn.cs** is the control script where the main operation takes place

**minimax_AI.cs** is the script that controls the computer

This method is taken reference from [https://www.geeksforgeeks.org/minimax-algorithm-in-game-theory-set-3-tic-tac-toe-ai-finding-optimal-move/](https://www.geeksforgeeks.org/minimax-algorithm-in-game-theory-set-3-tic-tac-toe-ai-finding-optimal-move/)

The main concept is to let the system run through the possible spots to select and determine which of these spots will result in an earlier win. It uses Maximizer and Minimizer to compete against each other to find the best move for the computer whenever the user selects a spot. By using this method, it is impossible for the computer to lose.

However, one problem with this method is that, the computer always makes similar steps by always starting on the top-left corner. Hence, there is not much creativity coming from this algorithm.

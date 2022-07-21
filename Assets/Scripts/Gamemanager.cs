using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetPositions();
    }
    public void ComputerScores(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetPositions();
    }

    private void ResetPositions(){
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
    }
}

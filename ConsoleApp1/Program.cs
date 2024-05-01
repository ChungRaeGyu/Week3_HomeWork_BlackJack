
using System;
using System.Collections.Generic;

public enum Suit { Hearts, Diamonds, Clubs, Spades }
public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

// 카드 한 장을 표현하는 클래스

// 덱을 표현하는 클래스


// 패를 표현하는 클래스

// 플레이어를 표현하는 클래스


// 여기부터는 학습자가 작성
// 딜러 클래스를 작성하고, 딜러의 행동 로직을 구현하세요.



class Program
{
    static void Main(string[] args)
    {
        GameManager gameManager = new GameManager();
        gameManager.GameStart();
    }
}

// 블랙잭 게임을 구현하세요. 
internal class GameManager
{
    Card card;
    Deck deck;
    Hand hand;
    Player player;
    Dealer dealer;
    public GameManager()
    {

    }
    public void Initailize()
    {
        
    }
    public void GameStart()
    {

    }
}
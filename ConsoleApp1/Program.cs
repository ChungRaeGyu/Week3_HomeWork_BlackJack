
using System;
using System.Collections.Generic;
using System.Xml.Linq;

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
    ConsoleUtility consoleUtility;
    public GameManager()
    {
        Initailize();
    }
    public void Initailize()
    {
        player = new Player();
        dealer = new Dealer();
        deck = new Deck();
        consoleUtility = new ConsoleUtility();

        //카드를 받습니다.
        player.DrawCardFromDeck(deck);
        dealer.DrawCardFromDeck(deck);
        player.DrawCardFromDeck(deck);
        dealer.DrawCardFromDeck(deck);
    }
    public void GameStart()
    {
        Console.Clear();
        player.MyHand();
        Console.WriteLine("현재 총 합계 : " + player.Hand.GetTotalValue());
        if (player.Hand.GetTotalValue() > 21)
        {
            Lose("Player");
        }
        else
        {
            Console.WriteLine("1. 더받기");
            Console.WriteLine("0. 그만 받기");
            switch (consoleUtility.PromtChoice(0, 1))
            {
                case 0:
                    CheckWhoWin();
                    break;
                case 1:
                    player.DrawCardFromDeck(deck);
                    GameStart();
                    break;
            }
        }
    }

    private void CheckWhoWin()
    {
        while (true)
        {
            Console.WriteLine("Dealer Hand");
            dealer.MyHand();
            Console.WriteLine("현재 총 합계 : " + dealer.Hand.GetTotalValue());

            if (dealer.Hand.GetTotalValue() >= 17)
            {
                break;
            }
            dealer.DrawCardFromDeck(deck);
            Thread.Sleep(1000);

        }
        if (dealer.Hand.GetTotalValue() > 21)
        {
            Lose("Dealer");
        }
        else if (player.Hand.GetTotalValue() < dealer.Hand.GetTotalValue())
        {
            Console.WriteLine("Dealer 승리");
        }
        else if (player.Hand.GetTotalValue() > dealer.Hand.GetTotalValue())
        {
            Console.WriteLine("Player 승리");
        }
        else
        {
            Console.WriteLine("무승부");
        }
    }

    private static void Lose(string name)
    {
        Console.WriteLine($"{name} 패배!");
        Console.WriteLine("가진 패가 21을 넘어서 패배 하셨습니다.");
        Console.ReadKey();
    }
}
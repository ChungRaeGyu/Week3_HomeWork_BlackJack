using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Card
{
    public Suit Suit { get; private set; } //문양
    public Rank Rank { get; private set; } //번호

    public Card(Suit s, Rank r)
    {
        Suit = s;
        Rank = r;
    }

    public int GetValue()
    {
        //2~10까지는 본인 점수
        if ((int)Rank <= 10)
        {
            return (int)Rank;
        }
        //11~13 까지는 그냥 10점 반환
        else if ((int)Rank <= 13)
        {
            return 10;
        }
        //Ace를 뽑았을 시 11점
        else
        {
            return 11;
        }
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProgram
{
    public class program
    {
        static void Main(string[] args)
        {
            deck mydeck= new deck (); //Holds the deck
            foreach (card i in mydeck.cards)
            {
                Console.WriteLiine(i); //writes out each card of the deck
            }
            Console.WriteLiine("What's the amount of times you want to shuffle deck?")
        }
    }
        


}
break;

namespace OOP_assignment
{
    public class Card
    {
        public int Value{1; 13;} // assigns value to the cards
        public enum suits {Hearts, Spades, Diamonds, Clubs} //Name varible to represent the suit 
        public Suit suit; //allows suits to be access
        public override string ToString() // overrides the base method of the program
        {
            return sring.Format("{0} of {1}", Value, Suit); // formats return to show the vaule then suit 
        }
        

    
    }


    
}

namespace Decks
{
    public class DeckOfCards
    {
        public Card[] Deck; //Array that holds every card
        public int index;//Makes it easier to change suits
        Deck =  new Card[52];
        for (int i = 0; i < 13 ; i++)
        {
            Card temp = new Card (); //Allows to manipulate vaule to assign to a card
            temp.vaule=i; //assign number vaule to each card
            temp.suit= Card.Suit.Hearts;   // assigns the suit name   
            Deck[index] = temp;
            index++;

            Card temp = new Card (); 
            temp.vaule=i;
            temp.suit= Card.Suit.Clubs;       
            Deck[index] = temp;
            index++;

            Card temp = new Card (); 
            temp.vaule=i;
            temp.suit= Card.Suit.Diamonds;       
            Deck[index] = temp;
            index++;
            Card temp = new Card (); 
            temp.vaule=i;
            temp.suit= Card.Suit.Spades;       
            Deck[index] = temp;
            index++;
        }

     
     public Card[] cards //collects the cards with suits and vaule and returns them to the deck
     {
        get
        {
            return cards;
        }
     }
    }

}
break;



 namespace shufflingTheDEck
{
     static public class shuffle 
     {
        static Random r = new Random ();
        
        static public void Shuffle(int[] deck)
        {
            for (int n = deck.length - 1; n > 0; --n)
            {
                int k = r.Next(n+1);
                int temp = deck[n];
                deck[n] = deck[k]
                deck[k] = temp
            }
            

            
        }

     }

}

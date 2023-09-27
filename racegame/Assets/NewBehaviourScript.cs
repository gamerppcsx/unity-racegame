using System.Collections;
using System.Collections.Generic;


using System;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;




namespace Assets
{
    class Deck:MonoBehaviour
    {
        public List<GameObject> deck;
        public void Fill()
        {
            GameObject c1 = Instantiate(deck[0]);
            GameObject c2 = Instantiate(deck[1]);
            GameObject c3 = Instantiate(deck[2]);
            GameObject c4 = Instantiate(deck[3]);
            GameObject c5 = Instantiate(deck[4]);
            GameObject c6 = Instantiate(deck[5]);
        }

    }
}

/*namespace Assets
{
    class Deck:MonoBehaviour
    {
        public GameObject card1;
        public GameObject card2;
        public GameObject card3;
        public GameObject card4;
        public GameObject card5;
        public GameObject card6;

        public GameObject[] deck;

        public void Start ()
        {
            deck = new GameObject[5];
            GameObject c1 = Instantiate(card1) as GameObject;
            GameObject c2 = Instantiate(card2) as GameObject;
            GameObject c3 = Instantiate(card3) as GameObject;
            GameObject c4 = Instantiate(card4) as GameObject;
            GameObject c5 = Instantiate(card5) as GameObject;
            GameObject c6 = Instantiate(card6) as GameObject;
        }

    }
}*/



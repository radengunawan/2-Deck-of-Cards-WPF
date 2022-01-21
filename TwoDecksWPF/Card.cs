﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDecksWPF
{
    class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return $"{this.Value} of {this.Suit}"; }
        }

        public override string ToString()
        {
            return this.Name;
        }

    }

}

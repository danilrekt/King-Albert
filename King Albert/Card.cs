using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace King_Albert
{
    public enum Suit
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public partial class Card : UserControl
    {
        public Suit Suit { get; private set; }
        public int Rank { get; private set; } //2 ... 13 (0 ... 11)
        public Card(Suit suit, int rank, Image image)
        {
            InitializeComponent();

            pictureBox1.Image = image;
        }

    }
}

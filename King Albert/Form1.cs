using System.Data.OleDb;

namespace King_Albert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var creator = new CardCreator();
            var oldCards = creator.CreateCards();

            var cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                var idx = Random.Shared.Next(0, oldCards.Count);
                var card = oldCards[idx];
                oldCards.RemoveAt(idx);
                cards.Add(card);
            }



        }
    }
}

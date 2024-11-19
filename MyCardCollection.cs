using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class MyCardCollection : Form
    {
        public MyCardCollection(Dictionary<string, bool> collection)
        {
            InitializeComponent();

            foreach (var card in collection)
            {
                if (card.Value)
                {
                    TreeNode tn = new TreeNode(card.Key);
                    tvCards.Nodes.Add(tn);
                }
            }
        }
    }
}

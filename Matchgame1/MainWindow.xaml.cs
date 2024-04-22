using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Reflection;

namespace Matchgame1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            SetupGame();
        }
        private void SetupGame()
        {
            List<string> bakeryEmoji = new List<string>
            {
                "🥛","🥛",
                "🥚","🥚",
                "🍓","🍓",
                "🍍","🍍",
                "🍫","🍫",
                "🍪","🍪",
                "🎂","🎂",
                "🥤","🥤",
                "🍉","🍉"
            };
            Shuffle(bakeryEmoji);

            // Populate the grid with emojis
            int index = random.Next(bakeryEmoji.Count);
            foreach (TextBlock textBlock in GameGrid.Children.OfType<TextBlock>()) {

                String nextEmoji = bakeryEmoji[index];
                textBlock.Text = nextEmoji;
                bakeryEmoji.RemoveAt(index);
            }
        }
        private void Shuffle(List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace Calendar_WPF5
{
    /// <summary>
    /// Логика взаимодействия для EmotionsDataPage.xaml
    /// </summary>
    public partial class EmotionsDataPage : Page
    {
        List<UserControlEmoji> emojies = new List<UserControlEmoji>();
        public EmotionsDataPage()
        {
            InitializeComponent();


            string path = Path.GetFullPath(@"..\..\..\");
            path = path + "Calendar_WPF5\\icon\\";

            UserControlEmoji nerd = new UserControlEmoji();
            nerd.checkEmoji.Content = "Нерд";
            nerd.EmotionIcon.Source = new BitmapImage(new Uri(path + "NerdEmotion_clipdrop-background-removal.png"));

            UserControlEmoji goblin = new UserControlEmoji();
            goblin.checkEmoji.Content = "Злой гоблин";
            goblin.EmotionIcon.Source = new BitmapImage(new Uri(path + "goblin.png"));
            
            UserControlEmoji sad = new UserControlEmoji();
            sad.checkEmoji.Content = "Грустный";
            sad.EmotionIcon.Source = new BitmapImage(new Uri(path + "sad.png"));

            UserControlEmoji happy = new UserControlEmoji();
            happy.checkEmoji.Content = "Веселый";
            happy.EmotionIcon.Source = new BitmapImage(new Uri(path + "happy.png"));

            emojies.Add(nerd);
            emojies.Add(goblin);
            emojies.Add(sad);
            emojies.Add(happy);
            Emotions.ItemsSource = emojies;
        }

        private void SaveExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            PageCalendar pageCalendar = new PageCalendar();
            DateControl dateControl = new DateControl();
            dateControl.DayBtn.Content = emojies[0];
            window.framik.Content = pageCalendar;
        }

        private void ToMainPage_Click(object sender, RoutedEventArgs e)
        {
            framik.Content = new PageCalendar();
        }
    }
}

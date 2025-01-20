using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellowWorldHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Message helloWorld = new Message("Hello World", "English");
            richTextBox1.Text = helloWorld.greeting.ToString() + " - " + helloWorld.language.ToString();
            List<Message> messageList = new List<Message>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] translatedGreeting =
            {
                "Hola Mundo - Spanish",
                "Bonjour le Monde - French",
                "Hallo Welt - German",
                "Ciao Mondo - Italian",
                "Olá Mundo - Portuguese",
                "Привет мир - Russian",
                "你好世界 - Chinese",
                "こんにちは世界 - Japanese",
                "مرحبًا بالعالم - Arabic",
                "नमस्ते दुनिया - Hindi"
            };

            Random random = new Random();
            translatedMessage helloTranslated = new translatedMessage(translatedGreeting[random.Next(translatedGreeting.Length)]);
            richTextBox1.Text = helloTranslated.translatedGreeting.ToString();
            List<translatedMessage> messageList = new List<translatedMessage>();
        }




    }

    
}

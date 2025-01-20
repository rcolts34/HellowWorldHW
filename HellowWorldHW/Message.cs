using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorldHW
{
    public class Message
    {
        public string greeting;
        public string language;
        
        public Message(string greeting, string language)
        {
            this.greeting = greeting;
            this.language = language;
        }
    }

    public class translatedMessage
    {
        public string translatedGreeting;

        public translatedMessage(string translatedGreeting)
        {
            this.translatedGreeting = translatedGreeting;
        }
    }

}

using System;

namespace Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Petya", true);
            Message message = new Message(author.username);
            message.sendTime = DateTime.Now;
            message.content = "SuperSecret text";
            message.isReply = true;
            message.WriteMessageToConsole();
            author.GetAuthorInfo();
        }
    }

    class Message
    {
        public string username;
        public DateTime sendTime;
        public string content;
        public bool isRead = false;
        public bool isReply;
        public Message(string username)
        {
            this.username = username;
        }
        public void WriteMessageToConsole()
        {
            Console.WriteLine($"@{username}: {content} | {sendTime} | is read:{isRead}| is reply: {isReply}");
        }
    }

    class Author
    {
        public string username;
        public bool status;
        public Author(string username, bool status)
        {
            this.username = username;
            this.status = status;
        }
        public void GetAuthorInfo()
        {
            Console.WriteLine($"Username: {username} | Is online: {status}");
        }


    }

}
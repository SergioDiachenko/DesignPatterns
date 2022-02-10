using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator._03_Example
{
    public class Client : IClient
    {
        public void Execute()
        { 
            var teamChat = new TeamChatroom();

            var steve = new Developer("Steve");
            var justin = new Developer("Justin");
            var jenna = new Developer("Jenna");
            var kim = new Tester("Kim");
            var julia = new Tester("Julia");
            teamChat.RegisterMembers(steve, justin, jenna, kim, julia);

            steve.Send("Hey everyone, we're going to be deploying at 2 pm today");
            kim.Send("Ok, thanks for letting us know");

            Console.WriteLine();
            steve.SendTo<Developer>("Make sure to execute your unit tests before checking in!");
        }
    }
}

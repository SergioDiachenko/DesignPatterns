using System;

namespace DesignPatterns.Mediator._03_Example
{
    public abstract class TeamMember
    {
        private ChatRoom chatRoom;

        public TeamMember(string name)
        {
            Name = name;
        }

        public string Name { get; }

        internal void SetChatroom(ChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            this.chatRoom.Send(this.Name, message);
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            this.chatRoom.SendTo<T>(this.Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"from {from}: '{message}'");
        }
    }
}

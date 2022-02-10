using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Mediator._03_Example
{
    public class TeamChatroom : ChatRoom
    {
        private List<TeamMember> members = new List<TeamMember>();

        public override void Register(TeamMember member)
        {
            member.SetChatroom(this);
            this.members.Add(member);
        }

        public override void Send(string from, string message)
        {
            this.members.ForEach(_ => _.Receive(from, message));
        }

        public void RegisterMembers(params TeamMember[] teamMembers)
        {
            foreach (var member in teamMembers)
            {
                this.Register(member);
            }
        }

        public override void SendTo<T>(string from, string message)
        {
            this.members.OfType<T>().ToList().ForEach(_ => _.Receive(from, message));
        }
    }
}

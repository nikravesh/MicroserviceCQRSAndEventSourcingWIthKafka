using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentCommand : BaseCommand
    {
        public required string Username { get; set; }
        public required string Comment { get; set; }
    }
}
#nullable enable
namespace SyncClipboard.Service.Command
{
    public class CommandInfo
    {
        public string CommandStr { get; set; } = "";
        public string Time { get; set; } = "";

        public override string ToString()
        {
            return CommandStr + Time;
        }
    }
}

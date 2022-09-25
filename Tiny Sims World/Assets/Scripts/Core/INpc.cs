namespace TinySimsWorld.Core
{
    public interface INpc
    {
        string npcName { get; set; }
        void Talking();
    } 
}
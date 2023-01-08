namespace TestBlazorWASM.Shared
{
    public partial class TLNavMenu
    {
        private bool boolDisplayBlock = true;
        private string? custDisplayBlock => boolDisplayBlock ? "collapse" : null;
        private void ToggleNavMenu() => boolDisplayBlock = !boolDisplayBlock;
    }
}

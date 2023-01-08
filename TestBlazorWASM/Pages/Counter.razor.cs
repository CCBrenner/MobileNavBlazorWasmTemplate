using Microsoft.AspNetCore.Components;
using TestBlazorWASM.Services;
using TestBlazorWASM.Services.Contracts;

namespace TestBlazorWASM.Pages
{
    public partial class Counter
    {
        [Inject]
        public ICounterService CounterService { get; set; }
        public string CubeSize { get; set; } = "mCubeSize";

        public void SetCubeSize(char size)
        {
            switch (size)
            {
                case 'T':
                    CubeSize = "xsCubeSize";
                    break;
                case 'S':
                    CubeSize = "sCubeSize";
                    break;
                case 'M':
                    CubeSize = "mCubeSize";
                    break;
                case 'L':
                    CubeSize = "lCubeSize";
                    break;
                case 'H':
                    CubeSize = "xlCubeSize";
                    break;
                default:
                    CubeSize = "mCubeSize";
                    break;
            }
        }
    }
}

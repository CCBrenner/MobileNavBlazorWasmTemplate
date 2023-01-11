using Microsoft.AspNetCore.Components;
using System.Drawing;
using MobileNavBlazorWasmTemplate.Services;
using MobileNavBlazorWasmTemplate.Services.Contracts;

namespace MobileNavBlazorWasmTemplate.Pages
{
    public partial class Counter
    {
        [Inject]
        public ICounterService CounterService { get; set; }
        public string CubeSize { get; set; } = "7px";
        public string CubeColor { get; set; } = "red";
        public string CubeShape { get; set; } = "";

        protected void SetCubeSize(char size)
        {
            switch (size)
            {
                case 'T':
                    CubeSize = "3px";
                    break;
                case 'S':
                    CubeSize = "5px";
                    break;
                case 'M':
                    CubeSize = "7px";
                    break;
                case 'L':
                    CubeSize = "10px";
                    break;
                case 'H':
                    CubeSize = "15px";
                    break;
                default:
                    CubeSize = "7px";
                    break;
            }
        }
        protected void SetCubeShape(char shape)
        {
            switch (shape)
            {
                case 'S':
                    CubeShape = "";
                    break;
                case 'C':
                    CubeShape = "cube-circle";
                    break;
                case 'D':
                    CubeShape = "cube-diamond";
                    break;
                default:
                    CubeShape = "";
                    break;
            }
        }
        protected void SetCubeColor(char shape)
        {
            switch (shape)
            {
                case 'R':
                    CubeColor = "red";
                    break;
                case 'G':
                    CubeColor = "green";
                    break;
                case 'B':
                    CubeColor = "blue";
                    break;
                case 'O':
                    CubeColor = "orange";
                    break;
                case 'U':
                    CubeColor = "purple";
                    break;
                case 'Y':
                    CubeColor = "yellow";
                    break;
                case 'I':
                    CubeColor = "deeppink";
                    break;
                default:
                    CubeColor = "blue";
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp20
{
    interface Window
    {
        void Draw();
        string GetDescription();
    }
    class SimpleWindow : Window
    {
        public void Draw()
        {
            Console.WriteLine("================");
            Console.WriteLine("||Simple Window||");
            Console.WriteLine("================");
        }

        public string GetDescription()
        {
            return "SimpleWindow";
        }
    }
    class WindowDecorate : Window
    {
        public Window Window { get; set; }
        public WindowDecorate( Window window)
        {
            Window = window;
        }
        public void Draw()
        {
            
            Console.WriteLine("*****************************");
            Console.WriteLine("**********Decorate***********");
            Console.WriteLine("*****************************");
        }

        public string GetDescription()
        {
            return "WindowDecorate";
        }
    }
    class HorizontalScrollBar : WindowDecorate
    {
        public HorizontalScrollBar(Window window):base(window)
        {
        }
        public void DrawHorizontal()
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("_______________________");
            Draw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleWindow simple = new SimpleWindow();
            WindowDecorate window = new WindowDecorate(simple);
            HorizontalScrollBar horizontal = new HorizontalScrollBar(window);
            horizontal.DrawHorizontal();
        }
    }
}

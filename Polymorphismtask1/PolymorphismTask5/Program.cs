using PolymorphismTask5.Model;

namespace PolymorphismTask5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a reference of base class
            GeometricFigure figure;

            // Rectangle
            figure = new RectangleFigure();
            // Get input for rectangle
            Console.WriteLine("\n--- Rectangle ---");
            figure.Accept();
            //display
            figure.Display();                
            figure.ComputeArea();            

            // Square
            figure = new SquareFigure();
            // Get input for square
            Console.WriteLine("\n--- Square ---");
            figure.Accept();                 
            figure.Display();                
            figure.ComputeArea();            

            // Circle
            figure = new CircleFigure();
            // Get input for circle
            Console.WriteLine("\n--- Circle ---");
            figure.Accept();
            // Display circle
            figure.Display();               
            figure.ComputeArea();            
        }
    }
}

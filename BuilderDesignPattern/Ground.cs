using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{

    public class Ground
    {
        public string Gallary { get; set; }
        public string GroundSurface { get; set; }
        public string Audience { get; set; }
    
      

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Gallary);
            Console.WriteLine("Engine: {0}", GroundSurface);
            Console.WriteLine("Body: {0}", Audience);
          
        }

    }
}

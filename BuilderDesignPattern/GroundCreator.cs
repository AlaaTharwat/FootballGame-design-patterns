using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class GroundCreator
    {
        private readonly IGroundBuilder GroundBuilder;
        public GroundCreator(IGroundBuilder builder)
        {
            GroundBuilder = builder;
        }

        public void CreateGround()
        {
            GroundBuilder.SetAudience();
            GroundBuilder.SetGallary();
            GroundBuilder.SetGroundSurface();

        }

        public Ground GetGround()
        {
            return GroundBuilder.GetGround();
        }

    }
}

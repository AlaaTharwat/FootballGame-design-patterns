using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public interface IGroundBuilder
    {
        void SetGallary();
        void SetGroundSurface();
        void SetAudience();

        Ground GetGround();
    }

    class ItalyGround : IGroundBuilder
    {
        Ground Ground = new Ground();
        public Ground GetGround()
        {
            return Ground;
        }

        public void SetAudience()
        {
            Ground.Gallary = "Italy Gallary";
        }

        public void SetGallary()
        {
            Ground.Audience = "Italy Audience";
        }

        public void SetGroundSurface()
        {
            Ground.GroundSurface = "Italy GroundSurface";
        }
    }



    class EnglandGround : IGroundBuilder
    {
        Ground Ground = new Ground();
        public Ground GetGround()
        {
            return Ground;
        }

        public void SetAudience()
        {
            Ground.Gallary = "England Gallary";
        }

        public void SetGallary()
        {
            Ground.Audience = "England Audience";
        }

        public void SetGroundSurface()
        {
            Ground.GroundSurface = "England GroundSurface";
        }
    }
}

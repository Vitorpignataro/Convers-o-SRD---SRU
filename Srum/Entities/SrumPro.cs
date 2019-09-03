using System;
using System.Collections.Generic;
using System.Text;

namespace Srum.Entities
{
    class SrumPro
    {
        public double ResX { get; set; }
        public double ResY { get; set; }
        public double Xmax { get; set; }
        public double Xmin { get; set; }
        public double Ymax { get; set; }
        public double Ymin { get; set; }

        public SrumPro()
        {
        }

        public SrumPro(double resX, double resY, double xmax, double xmin, double ymax, double ymin)
        {
            ResX = resX;
            ResY = resY;
            Xmax = xmax;
            Xmin = xmin;
            Ymax = ymax;
            Ymin = ymin;
        }

        public double SRUTOSRDX(double Xu)
        {
            return (Xu - Xmin) * ((ResX - Xmin) / (Xmax - Xmin)) + Xmin;
        }
        public double SRUTOSRDY(double Yu)
        {                  
            return (Yu - Ymin) * ((Ymin - ResY) / (Ymax - Ymin)) + ResY;
        }       

    }
}

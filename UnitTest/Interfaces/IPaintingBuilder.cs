using Bll.Core;
using Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Interfaces
{
    public interface IPaintingBuilder
    {
        void reset();
        void setId(int id);
        void setName(string name);
        void setPainter(PainterModel painter);
        PaintingModel getPainting();
    }
}

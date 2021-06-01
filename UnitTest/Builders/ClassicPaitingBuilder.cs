using Bll.Core;
using Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.Interfaces;

namespace UnitTest.Builders
{
    public class ClassicPaintingBuilder : IPaintingBuilder
    {
        private PaintingModel painting;

        public void reset()
        {
            painting = new PaintingModel()
            {
                style = PaintingStyle.Classic
            };
        }
        public void setId(int id)
        {
            painting.id = id;
        }
        public void setName(string name)
        {
            painting.name = name;
        }
        public void setPainter(PainterModel painter)
        {
            painting.painter = painter;
        }
        public PaintingModel getPainting()
        {
            return painting;
        }
    }
}

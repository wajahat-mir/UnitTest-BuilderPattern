using Bll.Core.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.Interfaces;

namespace UnitTest.Directors
{
    public class PaintingDirector
    {
        private readonly IPaintingRepositoryMockBuilder _paintingMockBuilder;
        private readonly IPaintingBuilder _paintingBuilder;
        public PaintingDirector(IPaintingRepositoryMockBuilder paintingMockBuilder, IPaintingBuilder paintingBuilder)
        {
            _paintingMockBuilder = paintingMockBuilder;
            _paintingBuilder = paintingBuilder;
        }

        public Mock<IPaintingRepository> constructGetNoPaintings()
        {
            _paintingMockBuilder.reset();
            _paintingMockBuilder.setGetPaintingsAsync(null);
            return _paintingMockBuilder.getPaintingRepositoryMock();
        }

        public Mock<IPaintingRepository> constructCreatePainting_Abstract_Successful()
        {
            _paintingBuilder.reset();
            _paintingBuilder.setId(1);
            _paintingBuilder.setName("Guernica");
            _paintingBuilder.setPainter(new Bll.Core.Models.PainterModel()
            {
                id = 1,
                name = "Picasso"
            });
            var painting = _paintingBuilder.getPainting();

            _paintingMockBuilder.reset();
            _paintingMockBuilder.setAddPaintingAsync(painting, painting);
            return _paintingMockBuilder.getPaintingRepositoryMock();
        }
    }
}

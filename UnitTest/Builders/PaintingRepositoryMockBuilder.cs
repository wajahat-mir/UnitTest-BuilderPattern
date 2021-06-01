using Bll.Core.Interfaces;
using Bll.Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.Interfaces;

namespace UnitTest.Builders
{
    public class PaintingRepositoryMockBuilder: IPaintingRepositoryMockBuilder
    {
        private Mock<IPaintingRepository> _paintingRepoMock;

        public void reset()
        {
            _paintingRepoMock = new Mock<IPaintingRepository>();
        }

        public void setGetPaintingsAsync(IEnumerable<PaintingModel> paintings)
        {
            _paintingRepoMock.Setup(m => m.GetPaintingsAsync()).ReturnsAsync(paintings);
        }

        public void setAddPaintingAsync(PaintingModel paintingInput, PaintingModel paintingOutput)
        {
            _paintingRepoMock.Setup(m => m.AddPaintingAsync(paintingInput)).ReturnsAsync(paintingOutput);
        }

        public Mock<IPaintingRepository> getPaintingRepositoryMock()
        {
            return _paintingRepoMock;
        }
    }
}

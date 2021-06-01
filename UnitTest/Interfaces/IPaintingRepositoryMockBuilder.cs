using Bll.Core.Interfaces;
using Bll.Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Interfaces
{
    public interface IPaintingRepositoryMockBuilder
    {
        public void reset();
        void setGetPaintingsAsync(IEnumerable<PaintingModel> paintings);
        void setAddPaintingAsync(PaintingModel paintingInput, PaintingModel paintingOutput);
        Mock<IPaintingRepository> getPaintingRepositoryMock();
    }
}
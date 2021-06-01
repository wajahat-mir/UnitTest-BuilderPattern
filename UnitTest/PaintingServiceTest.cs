using Bll.Core.Services;
using System;
using UnitTest.Builders;
using UnitTest.Directors;
using UnitTest.Interfaces;
using Xunit;

namespace UnitTest
{
    public class PaintingServiceTest
    {
        private readonly PaintingDirector _paintingDirector;

        [Fact]
        public async void GetPaitingsAsync_NoPaintingsAvailable_ReturnNull()
        {
            IPaintingRepositoryMockBuilder paintingRepositoryMockBuilder = new PaintingRepositoryMockBuilder();
            IPaintingBuilder paintingBuilder = new AbstractPaintingBuilder();
            var _paintingDirector = new PaintingDirector(paintingRepositoryMockBuilder, paintingBuilder);
            var paintingRepo = _paintingDirector.constructGetNoPaintings();

            var paintingService = new PaintingService(paintingRepo.Object);
            var result = await paintingService.GetPaintingsAsync();

            Assert.Null(result);
        }
    }
}

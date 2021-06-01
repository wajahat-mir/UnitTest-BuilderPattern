using Bll.Core.Interfaces;
using Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Core.Services
{
    public class PaintingService: IPaintingService
    {
        private readonly IPaintingRepository _paintingRepository;
        public PaintingService(IPaintingRepository paintingRepository)
        {
            _paintingRepository = paintingRepository;
        }

        public async Task<IEnumerable<PaintingModel>> GetPaintingsAsync()
        {
            return await _paintingRepository.GetPaintingsAsync();
        }
    }
}

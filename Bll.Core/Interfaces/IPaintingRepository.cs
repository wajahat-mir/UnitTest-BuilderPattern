using Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Core.Interfaces
{
    public interface IPaintingRepository
    {
        Task<IEnumerable<PaintingModel>> GetPaintingsAsync();
        Task<PaintingModel> AddPaintingAsync(PaintingModel painting);
    }
}

namespace Bll.Core.Models
{
    public class PaintingModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public PainterModel painter { get; set; }
        public PaintingStyle style { get; set; }
    }
}

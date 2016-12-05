using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS.QueryStack.Application.Outputs
{
    public class VideoItemDto
    {
        public Guid VideoId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int Views { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPhotoContent.Api.Models
{
    public class AlbumContentModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

using System;

namespace GEFin.Api.Dto
{
    public class UserForDetailed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Claims { get; set; }
    }
}
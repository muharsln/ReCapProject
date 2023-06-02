using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string? CarName { get; set; }
        public string? CustomerName { get; set; }
        public string? RentDate { get; set; }
        public string? ReturnDate { get; set; }
    }
}
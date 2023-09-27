﻿using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarImageDTO:IDto
    {
        public  IFormFile File { get; set; }
        public int CarId { get; set; }
    }
}

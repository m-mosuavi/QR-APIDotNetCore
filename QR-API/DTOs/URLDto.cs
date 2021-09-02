﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QR_API.DTOs
{
    public class URLDto:BaseDto
    {
        [Required]
        public string URL { get; set; }
    }
}

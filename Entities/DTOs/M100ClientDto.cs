﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.DTOs
{
    public class M100ClientDto : IDto
    {
        public int ClientId { get; set; }
        public int PersonId { get; set; }
    }
}

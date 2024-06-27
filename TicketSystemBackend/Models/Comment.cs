﻿using System;
using System.Collections.Generic;

namespace TicketSystemBackend.Models;

public partial class Comment
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Body { get; set; }

    public virtual User? User { get; set; }
}

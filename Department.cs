﻿using System;
using System.Collections.Generic;

namespace ADO_NET_07_Homework;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HealthcareAppointment.Models.Models;

public partial class Order1
{
    public int OrderId { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
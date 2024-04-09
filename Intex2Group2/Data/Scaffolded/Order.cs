﻿using System;
using System.Collections.Generic;

namespace Intex2Group2.Data.Scaffolded;

public partial class Order
{
    public int TransactionId { get; set; }

    public string CustomerId { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string DayOfWeek { get; set; } = null!;

    public byte Time { get; set; }

    public string EntryMode { get; set; } = null!;

    public double Amount { get; set; }

    public string TypeOfTransaction { get; set; } = null!;

    public string CountryOfTransaction { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string Bank { get; set; } = null!;

    public string TypeOfCard { get; set; } = null!;

    public int Fraud { get; set; }
}

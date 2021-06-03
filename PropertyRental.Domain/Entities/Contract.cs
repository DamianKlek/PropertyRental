﻿using PropertyRental.Domain.Common;
using System;

namespace PropertyRental.Domain.Entities
{
  public class Contract : AuditableEntity
  {
    public DateTime StartRentDate { get; set; }
    public DateTime EndRentTime { get; set; }
    public int RentCost { get; set; }
    public int PropertyRentId { get; set; }
    public PropertyRent PropertyRent { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; }
  }
}
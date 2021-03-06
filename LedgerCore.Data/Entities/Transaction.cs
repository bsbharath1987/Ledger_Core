﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using LedgerCore.Data.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LedgerCore.Data.Entities
{
    public class Transaction : DBEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public TransactionType.Type Type { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        public virtual Account Account { get; set; }
        public Guid? ToAccountId { get; set; }
        public string Recipient { get; set; }

    }
}

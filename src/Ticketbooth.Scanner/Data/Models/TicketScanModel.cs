﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ticketbooth.Scanner.Data.Models
{
    public class TicketScanModel
    {
        public TicketScanModel()
        {
        }

        public TicketScanModel(SeatModel seat)
        {
            Seat = seat;
        }

        [Key]
        public int Id { get; set; }

        public SeatModel Seat { get; set; }

        public bool OwnsTicket { get; set; }

        public string Name { get; set; }

        public bool HasResult => !(Name is null);

        public void SetScanResult(bool ownsTicket, string name)
        {
            if (name is null)
            {
                throw new ArgumentException("Name cannot be null");
            }

            OwnsTicket = ownsTicket;
            Name = name;
        }
    }
}
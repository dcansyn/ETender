﻿using ETender.Sourcing.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETender.Sourcing.Data.Interfaces
{
    public interface ISourcingContext
    {
        IMongoCollection<Auction> Auctions { get; }
        IMongoCollection<Bid> Bids { get; }
    }
}

﻿using ETender.Sourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETender.Sourcing.Repositories.Interfaces
{
    public interface IAuctionRepository
    {
        Task<IEnumerable<Auction>> GetAuctions();
        Task<Auction> GetAuction(string id);
        Task<Auction> GetAuctionByName(string name);
        Task Create(Auction auction);
        Task<bool> Update(Auction auction);
        Task<bool> Delete(string id);
    }
}

﻿using NoteBook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Domain.Abstract
{
    public interface IRepository
    {
        IQueryable<State> States { get; }
        IQueryable<AnOrder> Orders { get; }

        AnOrder SaveOrder(AnOrder _order);
        void DelOrder(int _orderId);
        void addOrder(AnOrder _order);
    }
}

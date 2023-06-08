﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceCurrencyValue.Models;

namespace WindowsServiceCurrencyValue.Interfaces.Services
{
    public interface ITxtMaker
    {
        void WriteData(List<DataFormat> data);
        void WriteStopMessage();
    }
}

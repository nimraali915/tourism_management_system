﻿using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomBLL
    {
        RoomDAL rDAL = new RoomDAL();
        public bool InsertRoomBLL(RoomBook rbook)
        {

            return rDAL.RoomInsertDAL(rbook);
        }
    }
}

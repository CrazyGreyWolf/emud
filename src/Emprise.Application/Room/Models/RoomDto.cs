﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emprise.Application.Room.Models
{
    public class RoomDto
    {  
        
        /// <summary>
        /// 房间名
        /// </summary>
        [StringLength(32)]
        public string Name {  get; set; }

        /// <summary>
        /// 东
        /// </summary>
        public int East {  get; set; }



        /// <summary>
        /// 西
        /// </summary>
        public int West {  get; set; }

        /// <summary>
        /// 南
        /// </summary>
        public int South {  get; set; }

        /// <summary>
        /// 北
        /// </summary>
        public int North {  get; set; }

        /// <summary>
        /// 房间说明
        /// </summary>
        [StringLength(500)]
        public string Description {  get; set; }

        /// <summary>
        /// 是否可以战斗
        /// </summary>
        public bool CanFight {  get; set; }

        /// <summary>
        /// 是否可以挖矿
        /// </summary>
        public bool CanDig {  get; set; }

        /// <summary>
        /// 是否可以伐木
        /// </summary>
        public bool CanCut {  get; set; }

        /// <summary>
        /// 是否可以钓鱼
        /// </summary>
        public bool CanFish {  get; set; }

        /// <summary>
        /// 是否可以采药
        /// </summary>
        public bool CanCollect {  get; set; }

        /// <summary>
        /// 是否可以打猎
        /// </summary>
        public bool CanHunt {  get; set; }
    }
}

﻿using System;
namespace Molla_Backend.Areas.Admin.ViewModels.CustomerImpression
{
	public class CustomerImpressionVM
	{
        public int Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Comments { get; set; }
        public bool Status { get; set; }
        public string CreateDate { get; set; }
    }
}


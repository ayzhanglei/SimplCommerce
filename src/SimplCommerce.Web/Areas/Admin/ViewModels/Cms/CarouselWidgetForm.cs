﻿using System.Collections.Generic;

namespace SimplCommerce.Web.Areas.Admin.ViewModels.Cms
{
    public class CarouselWidgetForm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Zone { get; set; }

        public IList<CarouselWidgetItemForm> Items = new List<CarouselWidgetItemForm>();
    }
}

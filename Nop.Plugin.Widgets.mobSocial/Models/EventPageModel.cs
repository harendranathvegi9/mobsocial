﻿using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Localization;

namespace Nop.Plugin.Widgets.MobSocial.Models
{
    public class EventPageModel : BaseNopEntityModel, ILocalizedModel<EventPageLocalizedModel>
    {

        public EventPageModel()
        {
            Locales = new List<EventPageLocalizedModel>();
            AddHotelModel = new EventPageHotelModel();
            AddPictureModel = new EventPageAddPictureModel();
            Pictures = new List<EventPagePictureModel>();
            Hotels = new List<EventPageHotelModel>();

        }

        public string Name { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress1 { get; set; }
        public string LocationAddress2 { get; set; }
        public string LocationState { get; set; }
        public string LocationCity { get; set; }
        public string LocationZipPostalCode { get; set; }
        public string LocationCountry { get; set; }
        public string LocationPhone { get; set; }
        public string LocationWebsite { get; set; }
        public string LocationEmail { get; set; }
        public DateTime StartDate { get; set; }
        [UIHint("DateTimeNullable")]
        public DateTime? EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        [AllowHtml]
        public string Description { get; set; }

        [AllowHtml]
        public string MetaKeywords { get; set; }

        [AllowHtml]
        public string MetaDescription { get; set; }

        [AllowHtml]
        public string MetaTitle { get; set; }

        [AllowHtml]
        public string SeName { get; set; }

        public string MainPictureUrl { get; set; }

        public IList<EventPageLocalizedModel> Locales { get; set; }
        
        public List<EventPageHotelModel> Hotels { get; set; }

        public List<EventPagePictureModel> Pictures { get; set; }

        public EventPageAddPictureModel AddPictureModel { get; set; }

        public EventPageHotelModel AddHotelModel { get; set; }


        public class EventPageAddPictureModel : BaseNopModel
        {
            [UIHint("Picture")]
            public int PictureId { get; set; }

            //[NopResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.Picture")]
            public string PictureUrl { get; set; }

            //[NopResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

        }

        public string FullSizeImageUrl { get; set; }
    }

    public partial class EventPageLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [AllowHtml]
        public string MetaKeywords { get; set; }

        [AllowHtml]
        public string MetaDescription { get; set; }

        [AllowHtml]
        public string MetaTitle { get; set; }

        [AllowHtml]
        public string SeName { get; set; }
    }
}
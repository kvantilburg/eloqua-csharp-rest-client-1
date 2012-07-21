﻿
namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class ContactSegment : IRestObject
    {
        public int? count { get; set; }

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string RequestResource
        {
            get { return "/assets/contact/segment"; }
        }

        public string Depth { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }

        #endregion

    }
}
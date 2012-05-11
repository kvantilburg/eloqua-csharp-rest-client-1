﻿namespace Eloqua
{
    public interface IRestObject
    {
        int Id { get; }
        string Name { get; set; }
        string RequestResource { get; }
        string RequestResourceName { get; }

        string Depth { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
        string SearchTerm { get; set; }
    }
}
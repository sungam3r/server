﻿using Microsoft.AspNetCore.Http;

namespace GraphQL.Server.Ui.Voyager
{
    /// <summary>
    /// Options to customize <see cref="VoyagerMiddleware"/>
    /// </summary>
    public class GraphQLVoyagerOptions
    {
        /// <summary>
        /// The Voyager EndPoint
        /// </summary>
        public PathString Path { get; set; } = "/ui/voyager";

        /// <summary>
        /// The GraphQL EndPoint
        /// </summary>
        public PathString GraphQLEndPoint { get; set; } = "/graphql";
    }
}

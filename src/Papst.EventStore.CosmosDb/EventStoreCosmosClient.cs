﻿using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

namespace Papst.EventStore.CosmosDb
{
    internal class EventStoreCosmosClient : CosmosClient
    {
        public CosmosEventStoreOptions Options { get; internal set; }

        public EventStoreCosmosClient(IOptions<CosmosEventStoreOptions> options)
            : base(options.Value.Endpoint, options.Value.AccountSecret)
        {
            Options = options.Value;
            
        }

        /// <summary>
        /// Mockable Constructor
        /// </summary>
        protected EventStoreCosmosClient()
            : base()
        {
            Options = new CosmosEventStoreOptions();
        }
    }
}
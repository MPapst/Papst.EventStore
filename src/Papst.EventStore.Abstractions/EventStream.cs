﻿using System.Collections.Generic;
using System.Linq;

namespace Papst.EventStore.Abstractions
{
    /// <inheritdoc/>
    internal class EventStream : IEventStream
    {
        private List<EventStreamDocument> _documents;

        /// <inheritdoc/>
        public EventStreamDocument LatestSnapShot => _documents?.Where(doc => doc.DocumentType == EventStreamDocumentType.Snapshot).LastOrDefault();

        /// <inheritdoc/>
        public IReadOnlyList<EventStreamDocument> Stream => _documents;

        public EventStream(IEnumerable<EventStreamDocument> documents)
        {
            _documents = documents.ToList();
        }
        
    }
}
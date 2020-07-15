﻿using System.Threading.Tasks;

namespace Papst.EventStore.Abstractions
{
    /// <summary>
    /// IEventStream Aggregator, Applies all Event of a Stream to a Target Entity
    /// </summary>
    /// <typeparam name="TTargetType"></typeparam>
    public interface IEventStreamAggregator<TTargetType>
        where TTargetType: class, new()
    {
        /// <summary>
        /// Apply the Stream to a new Entity
        /// </summary>
        /// <param name="stream">The Stream</param>
        /// <returns></returns>
        Task<TTargetType> ApplyAsync(IEventStream stream);

        /// <summary>
        /// Apply the Stream to an existing entity
        /// </summary>
        /// <param name="stream">The Stream</param>
        /// <param name="target">The Target Entity Instance</param>
        /// <returns></returns>
        Task<TTargetType> ApplyAsync(IEventStream stream, TTargetType target);
    }
}
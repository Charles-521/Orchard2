﻿using System.Threading.Tasks;
using Orchard.Indexing;

namespace Orchard.Contents.Indexing
{
    public class DefaultContentIndexHandler : IContentItemIndexHandler
    {
        public Task BuildIndexAsync(BuildIndexContext context)
        {
            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.ContentItemId",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.ContentItemId, 
                    DocumentIndex.Types.Integer, 
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.ContentType",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.ContentType,
                    DocumentIndex.Types.Text,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.CreatedUtc",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.CreatedUtc,
                    DocumentIndex.Types.DateTime,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.Latest",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.Latest,
                    DocumentIndex.Types.Boolean,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.ModifiedBy",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.ModifiedBy,
                    DocumentIndex.Types.Text,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.ModifiedUtc",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.ModifiedUtc,
                    DocumentIndex.Types.DateTime,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.Number",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.Number,
                    DocumentIndex.Types.Integer,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.Published",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.Published,
                    DocumentIndex.Types.Boolean,
                    DocumentIndexOptions.Store));

            context.DocumentIndex.Entries.Add(
                "Content.ContentItem.PublishedUtc",
                new DocumentIndex.DocumentIndexEntry(
                    context.ContentItem.PublishedUtc,
                    DocumentIndex.Types.DateTime,
                    DocumentIndexOptions.Store));

            return Task.CompletedTask;
        }
    }
}

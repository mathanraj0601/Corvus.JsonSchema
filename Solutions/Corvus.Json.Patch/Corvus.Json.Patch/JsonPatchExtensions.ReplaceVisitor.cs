﻿// <copyright file="JsonPatchExtensions.ReplaceVisitor.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Runtime.CompilerServices;
using Corvus.Json.Patch.Model;
using Corvus.Json.Visitor;

namespace Corvus.Json.Patch;

/// <summary>
/// JSON Patch extensions.
/// </summary>
public static partial class JsonPatchExtensions
{
    private readonly struct ReplaceVisitor
    {
        public ReplaceVisitor(Replace patchOperation)
        {
            this.Value = patchOperation.Value;
            this.Path = patchOperation.Path;
        }

        public JsonAny Value { get; }

        public string Path { get; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Visit(ReadOnlySpan<char> path, in JsonAny nodeToVisit, ref VisitResult result)
        {
            VisitForReplace(path, nodeToVisit, this.Value, this.Path, ref result);
        }

        internal static void VisitForReplace(ReadOnlySpan<char> path, in JsonAny nodeToVisit, in JsonAny value, ReadOnlySpan<char> operationPath, ref VisitResult result)
        {
            int operationPathLength = operationPath.Length;

            // If we are the root, or our span starts with the path so far, we might be matching
            if (operationPathLength == 0 || operationPath.StartsWith(path))
            {
                if (operationPathLength == path.Length)
                {
                    // We are an exact match, so we can just replace this node.
                    result.Output = value;
                    result.Transformed = Transformed.Yes;
                    result.Walk = Walk.TerminateAtThisNodeAndKeepChanges;
                    return;
                }

                // Otherwise we need to continue, as we are on the path
                result.Output = nodeToVisit;
                result.Transformed = Transformed.No;
                result.Walk = Walk.Continue;
                return;
            }

            // If it didn't start with the span, we can give up on this whole tree segment
            result.Output = nodeToVisit;
            result.Transformed = Transformed.No;
            result.Walk = Walk.SkipChildren;
        }
    }
}
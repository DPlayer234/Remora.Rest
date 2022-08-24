﻿//
//  DataObjectConverterShared.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Remora.Rest.Json.Internal;

/// <summary>
/// Shared, non-generic code for <see cref="DataObjectConverter{TInterface, TImplementation}"/>.
/// </summary>
internal static class DataObjectConverterShared
{
    /// <summary>
    /// Type of <see cref="Missing"/>.
    /// </summary>
    private sealed class MissingValue
    {
    }

    /// <summary>
    /// Sentinel value for use by <see cref="BoundDataObjectConverter{TInterface, TImplementation}"/>.
    /// It indicates a specific property has not been read from JSON yet.
    /// </summary>
    public static readonly object Missing = new MissingValue();

    /// <summary>
    /// Throws a <see cref="JsonException"/> with the specified <paramref name="message"/>.
    /// </summary>
    /// <param name="message">The exception message.</param>
    [DoesNotReturn]
    public static void ThrowJsonException(string? message = null)
    {
        throw new JsonException(message);
    }
}

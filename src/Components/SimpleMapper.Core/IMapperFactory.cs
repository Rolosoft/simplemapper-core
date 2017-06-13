// <copyright file="IMapperFactory.cs" company="Rolosoft Ltd">
// (c) 2017, Rolosoft Ltd
// </copyright>

// Copyright 2017 Rolosoft Ltd
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace SimpleMapper.Core
{
    using System.Diagnostics.Contracts;

    using Contracts;

    /// <summary>
    /// The MapperFactory interface.
    /// </summary>
    /// <typeparam name="TSource">
    /// Type of source.
    /// </typeparam>
    /// <typeparam name="TDestination">
    /// Type of destination.
    /// </typeparam>
    [ContractClass(typeof(MapperFactoryContracts<,>))]
    public interface IMapperFactory<in TSource, out TDestination>
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="IMapper&lt;TSource, TDestination&gt;"/>.
        /// </returns>
        IMapper<TSource, TDestination> Create();
    }
}
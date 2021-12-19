﻿namespace Fluxera.Repository.Caching{	using System;	using System.Collections.Generic;	using System.Linq.Expressions;	using System.Threading.Tasks;	using Fluxera.Entity;	using Fluxera.Repository.Query;	using JetBrains.Annotations;	[UsedImplicitly]	internal sealed class NoCachingStrategy<TAggregateRoot, TKey> : ICachingStrategy<TAggregateRoot, TKey>		where TAggregateRoot : AggregateRoot<TAggregateRoot, TKey>	{		/// <inheritdoc />		public Task AddAsync(TAggregateRoot item)		{			return Task.CompletedTask;		}		/// <inheritdoc />		public Task AddAsync(IEnumerable<TAggregateRoot> items)		{			return Task.CompletedTask;		}		public Task UpdateAsync(TAggregateRoot item)		{			return Task.CompletedTask;		}		/// <inheritdoc />		public Task UpdateAsync(IEnumerable<TAggregateRoot> items)		{			return Task.CompletedTask;		}		/// <inheritdoc />		public async Task<long> CountAsync(Func<Task<long>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<long> CountAsync(			Expression<Func<TAggregateRoot, bool>> predicate,			Func<Task<long>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<TAggregateRoot> FindOneAsync(			Expression<Func<TAggregateRoot, bool>> predicate,			IQueryOptions<TAggregateRoot>? queryOptions,			Func<Task<TAggregateRoot>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<TResult> FindOneAsync<TResult>(			Expression<Func<TAggregateRoot, bool>> predicate,			Expression<Func<TAggregateRoot, TResult>> selector,			IQueryOptions<TAggregateRoot>? queryOptions,			Func<Task<TResult>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<IReadOnlyCollection<TAggregateRoot>> FindManyAsync(			Expression<Func<TAggregateRoot, bool>> predicate,			IQueryOptions<TAggregateRoot>? queryOptions,			Func<Task<IReadOnlyCollection<TAggregateRoot>>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<IReadOnlyCollection<TResult>> FindManyAsync<TResult>(			Expression<Func<TAggregateRoot, bool>> predicate,			Expression<Func<TAggregateRoot, TResult>> selector,			IQueryOptions<TAggregateRoot>? queryOptions,			Func<Task<IReadOnlyCollection<TResult>>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<bool> ExistsAsync(			Expression<Func<TAggregateRoot, bool>> predicate,			Func<Task<bool>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public Task RemoveAsync(TKey id)		{			return Task.CompletedTask;		}		/// <inheritdoc />		public Task RemoveAsync(IEnumerable<TKey> ids)		{			return Task.CompletedTask;		}		/// <inheritdoc />		public async Task<TAggregateRoot> GetAsync(			TKey id,			Func<Task<TAggregateRoot>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<TResult> GetAsync<TResult>(			TKey id,			Expression<Func<TAggregateRoot, TResult>> selector,			Func<Task<TResult>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}		/// <inheritdoc />		public async Task<bool> ExistsAsync(			TKey id,			Func<Task<bool>> setter)		{			return await setter.Invoke().ConfigureAwait(false);		}	}}
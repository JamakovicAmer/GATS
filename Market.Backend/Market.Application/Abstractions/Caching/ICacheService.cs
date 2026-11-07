namespace Market.Application.Abstractions.Caching;

/// <summary>
/// Simple "cache-aside" helper over <c>IDistributedCache</c>.
/// <para>
/// The starter registers it but does not use it anywhere. Without configuration it runs on an in-memory cache;
/// with a non-empty <c>ConnectionStrings:Redis</c> it runs on Redis, and handlers do not change.
/// </para>
/// <para>
/// Example: cache a public, rarely changing list for 5 minutes:
/// <code>
/// var dto = await cache.GetOrCreateAsync("lookups:cities", token => LoadCitiesAsync(token), TimeSpan.FromMinutes(5), ct);
/// </code>
/// Handlers that change the cached data must make sure stale entries are not served, e.g. by
/// including a version number in the key and increasing it after <c>SaveChangesAsync</c>.
/// </para>
/// </summary>
public interface ICacheService
{
    /// <summary>
    /// Returns the cached value for <paramref name="key"/>; if there is none, calls <paramref name="factory"/>,
    /// stores its result for <paramref name="ttl"/> and returns it. Values are stored as JSON,
    /// so <typeparamref name="T"/> must be a serializable DTO (not an EF entity).
    /// </summary>
    Task<T?> GetOrCreateAsync<T>(
        string key,
        Func<CancellationToken, Task<T>> factory,
        TimeSpan ttl,
        CancellationToken cancellationToken = default) where T : class;
}

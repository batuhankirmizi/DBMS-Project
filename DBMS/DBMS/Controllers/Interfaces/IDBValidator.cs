public interface IDBValidator
{
    /// <summary>
    /// Validates the given data <see cref="IDBValidator" /> interface.
    /// </summary>
    bool Validate(string username, string password);

    /// <summary>
    /// Logs the user in with the specified username and password.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="password">The password.</param>
    void Login(string username, string name, bool is_manager);
}

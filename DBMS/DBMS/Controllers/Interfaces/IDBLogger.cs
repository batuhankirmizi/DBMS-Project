namespace DBMS.Controllers.Interfaces
{
    public interface IDBLogger
    {
        /// <summary>
        /// Logs the login data.
        /// </summary>
        /// <param name="admin_id">The admin identifier.</param>
        /// <param name="username">The username.</param>
        /// <param name="logDetails">The log details.</param>
        void Log(int admin_id, string username, string logDetails);

        /// <summary>
        /// Log the login data if the login has been unsuccessful.
        /// </summary>
        /// <param name="admin_id">The admin identifier.</param>
        /// <param name="username">The username.</param>
        /// <param name="logDetails">The log details.</param>
        void FailLog(string username, string logDetails);
    }
}

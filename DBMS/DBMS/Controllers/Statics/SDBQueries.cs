public static class SDBQueries
{
    // Validator queries
    public static readonly string LOGIN_QUERY  = "SELECT * FROM " + SDBTables.ADMINISTRATION_USERS;

    public static readonly string LOGIN_HISTORY_QUERY  = "INSERT INTO " + SDBTables.ADMINISTRATION_LOGIN_HISTORY + " (admin_id, username, log_details) VALUES('";

    public static readonly string LOGIN_HISTORY_QUERY_FAILED  = "INSERT INTO " + SDBTables.ADMINISTRATION_LOGIN_HISTORY + " (username, log_details) VALUES('";
}

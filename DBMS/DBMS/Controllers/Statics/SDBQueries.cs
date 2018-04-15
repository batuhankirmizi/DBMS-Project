public static class SDBQueries
{
    // Login Page queries
    public static readonly string LOGIN_QUERY  = "SELECT * FROM " + SDBTables.ADMINISTRATION_USERS;

    public static readonly string LOGIN_HISTORY_QUERY  = "INSERT INTO " + SDBTables.ADMINISTRATION_LOGIN_HISTORY + " (admin_id, username, log_details) VALUES('";

    public static readonly string LOGIN_HISTORY_QUERY_FAILED  = "INSERT INTO " + SDBTables.ADMINISTRATION_LOGIN_HISTORY + " (username, log_details) VALUES('";

    // Main Page queries
    public static readonly string MAIN_GET_MEMBER_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_MEMBERS;
    public static readonly string MAIN_GET_FACILITY_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_FACILITIES;
    public static readonly string MAIN_GET_EMPLOYEE_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_EMPLOYEES;
    public static readonly string MAIN_GET_UNPAID_PAYMENT_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_PAYMENTS + " WHERE is_paid = 0";
    public static readonly string MAIN_GET_COURSE_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_COURSES;
    public static readonly string MAIN_GET_MEMBERSHIPS_ABOUT_TO_EXPIRE = "SELECT COUNT(membership_expiry_date) as c FROM " + SDBTables.MAINDB_MEMBERS + " WHERE DATEDIFF(day, getdate(), membership_expiry_date) < 10";
    public static readonly string MAIN_GET_EQUIPMENT_COUNT = "SELECT COUNT(*) AS c FROM " + SDBTables.MAINDB_EQUIPMENTS;
    public static readonly string MAIN_GET_OUT_OF_WARRANTY_EQUIPMENT = "SELECT COUNT(warranty) as c FROM " + SDBTables.MAINDB_EQUIPMENTS + " WHERE DATEDIFF(day, getdate(), DATEADD(year, warranty, date_of_arrival)) < 0";

    // Member Page queries
    public static readonly string MEMBER_GET_MEMBERS_QUERY = "SELECT id, name, surname FROM " + SDBTables.MAINDB_MEMBERS;
    public static readonly string MEMBER_GET_ID = "SELECT id FROM " + SDBTables.MAINDB_MEMBERS + " WHERE payment_id = ";
    public static readonly string MEMBER_DELETE_MEMBER = "DELETE FROM " + SDBTables.MAINDB_MEMBERS + " WHERE id = ";
    public static readonly string MEMBER_GET_MEMBER = "SELECT * FROM " + SDBTables.MAINDB_MEMBERS + " WHERE id = ";
    public static readonly string MEMBER_ADD_MEMBER = "INSERT INTO " + SDBTables.MAINDB_MEMBERS +
        " (payment_id, permission_id, name, surname, gender, age, email, phone_number, address, height, weight," +
        "birth_date, date_joined, membership_expiry_date, weekly_entrance_right) VALUES('";
    public static readonly string MEMBER_ADD_MEMBERSHIP = "INSERT INTO " + SDBTables.MAINDB_MEMBERSHIPS + "(member_id, new_payment_id, new_expiry_date, new_entrance_right) VALUES('";
    public static readonly string MEMBER_DELETE_MEMBERSHIP = "DELETE FROM " + SDBTables.MAINDB_MEMBERSHIPS + " WHERE new_payment_id = ";

    public static readonly string MEMBER_UPDATE_MEMBER = "UPDATE " + SDBTables.MAINDB_MEMBERS + " SET ";

    public static readonly string MEMBER_PERMISSION_GET_ID = "SELECT id FROM " + SDBTables.MAINDB_PERMISSIONS + " WHERE facility_access_level = ";
    public static readonly string MEMBER_GET_PERMISSION = "SELECT facility_access_level FROM " + SDBTables.MAINDB_PERMISSIONS + " WHERE id = ";
    public static readonly string MEMBER_ADD_PERMISSION = "INSERT INTO " + SDBTables.MAINDB_PERMISSIONS + "(facility_access_level) VALUES('";
    public static readonly string MEMBER_EXISTS_PERMISSION = "SELECT COUNT(facility_access_level) as c FROM " + SDBTables.MAINDB_PERMISSIONS + " WHERE facility_access_level = ";

    public static readonly string MEMBER_DELETE_PAYMENT = "DELETE FROM " + SDBTables.MAINDB_PAYMENTS + " WHERE id = ";

    public static readonly string MEMBER_PAYMENT_SELECT_MAX_ID = "SELECT MAX(id) as id FROM " + SDBTables.MAINDB_PAYMENTS;
    public static readonly string MEMBER_ADD_PAYMENT = "INSERT INTO " + SDBTables.MAINDB_PAYMENTS + " (amount, payment_due_date, description, is_paid) VALUES('";
    public static readonly string MEMBER_GET_PAYMENT = "SELECT amount FROM " + SDBTables.MAINDB_PAYMENTS + " WHERE id = ";

    public static readonly string MEMBER_ADD_MEMBER_IMPROVEMENTS = "INSERT INTO " + SDBTables.MAINDB_MEMBER_IMPROVEMENTS + "(member_id, weight, height, date) VALUES('";

    // Payments Page queries
    public static readonly string PAYMENT_GET_PAYMENTS = "SELECT * FROM " + SDBTables.MAINDB_MEMBERS + " JOIN "+ SDBTables.MAINDB_PAYMENTS + " ON Members.payment_id = Payments.id";
    public static readonly string PAYMENT_GET_ID = "SELECT id FROM " + SDBTables.MAINDB_PAYMENTS + " WHERE amount = ";
    public static readonly string PAYMENT_GET_PAYMENT = "SELECT * FROM " + SDBTables.MAINDB_PAYMENTS + " WHERE id = ";
    public static readonly string PAYMENT_CHANGE = "UPDATE " + SDBTables.MAINDB_PAYMENTS + " SET";

    // Facilities Page queries
    public static readonly string FACILITIES_GET_FACILITIES = "SELECT * FROM " + SDBTables.MAINDB_FACILITIES;
    public static readonly string FACILITIES_GET_FACILITY = "SELECT * FROM " + SDBTables.MAINDB_FACILITIES + " WHERE name = '";
    public static readonly string FACILITIES_GET_PERMISSION_ID = "SELECT id FROM " + SDBTables.MAINDB_PERMISSIONS + " WHERE facility_access_level = '";
    public static readonly string FACILITIES_GET_PERMISSION = "SELECT * FROM " + SDBTables.MAINDB_FACILITIES + " JOIN " + SDBTables.MAINDB_PERMISSIONS + " ON Facilities.permission_id = Perms.id WHERE name = '";
    public static readonly string FACILITIES_ADD_FACILTIY = "INSERT INTO " + SDBTables.MAINDB_FACILITIES + "(permission_id, name) VALUES('";
    public static readonly string FACILITIES_ADD_PERMISSION = "INSERT INTO " + SDBTables.MAINDB_PERMISSIONS + "(facility_access_level) VALUES('";
    public static readonly string FACILITIES_CHANGE_FACILITY = "UPDATE " + SDBTables.MAINDB_FACILITIES + " SET";
}

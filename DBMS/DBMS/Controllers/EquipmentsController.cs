using System;
using System.Collections.Generic;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    class EquipmentsController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        public bool HasEquipment()
        {
            bool eqExists = false;
            using(Reader = ExecuteQuery(SDBQueries.EQUIPMENTS_GET_EQUIPMENTS))
            {
                while (Reader.Read())
                {
                    eqExists = true;
                    break;
                }

                Reader.Close();
            }

            return eqExists;
        }

        public LinkedList<string> GetEquipments()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            using(Reader = ExecuteQuery(SDBQueries.EQUIPMENTS_GET_EQUIPMENTS))
            {
                while (Reader.Read())
                    toReturn.AddLast(Reader["id"] + " - " + Reader["equipment_name"]);

                Reader.Close();
            }

            return toReturn;
        }

        internal void AddEquipment(Equipment currentEquipment)
        {
            string query = SDBQueries.EQUIPMENTS_ADD_EQUIPMENT + currentEquipment.Name + "', '" + currentEquipment.Price.ToString() + "', '" + currentEquipment.Condition
                + "', '" + currentEquipment.DateOfArrival + "', '" + currentEquipment.WarrantyDuration + "');";
            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }

        internal Equipment GetEquipment(int id)
        {
            Equipment toReturn = null;

            string query = SDBQueries.EQUIPMENTS_GET_EQUIPMENT + id;
            using(Reader = ExecuteQuery(query))
            {
                while (Reader.Read())
                    toReturn = new Equipment(Reader["equipment_name"].ToString(), float.Parse(Reader["price"].ToString()), Reader["condition"].ToString(),
                        DateTime.Parse(Reader["date_of_arrival"].ToString()), int.Parse(Reader["warranty"].ToString()));
            }

            return toReturn;
        }

        private int GetEquipmentId(string equipmentName)
        {
            int id = 0;

            string query = SDBQueries.EQUIPMENTS_GET_EQUIPMENT_ID + "'" + equipmentName + "'";
            using(Reader = ExecuteQuery(query))
            {
                while (Reader.Read())
                {
                    id = Int32.Parse(Reader["id"].ToString());
                }
            }

            return id;
        }

        internal void DeleteEquipment(Equipment currentEquipment)
        {
            string query = SDBQueries.EQUIPMENTS_DELETE + GetEquipmentId(currentEquipment.Name);
            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }

        internal void ChangeEquipment(Equipment currentEquipment, Equipment newEquipment)
        {
            string query = SDBQueries.EQUIPMENTS_CHANGE;

            LinkedList<string> diff = currentEquipment.GetDifferences(newEquipment);

            if(diff.Contains("name"))
                query += "equipment_name = '" + newEquipment.Name + "' ";
            if (diff.Contains("price"))
                query += "price = '" + newEquipment.Price + "' ";
            if (diff.Contains("condition"))
                query += "condition = '" + newEquipment.Condition + "' ";
            if (diff.Contains("date_of_arrival"))
                query += "date_of_arrival = '" + newEquipment.DateOfArrival + "' ";
            if (diff.Contains("warranty"))
                query += "warranty = '" + newEquipment.WarrantyDuration + "' ";

            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }
    }
}

using DTO_TourDuLich;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDuLich;


namespace DAL_TourDuLich
{
    public class DAL_Tour : ConnectionString
    {
        NpgsqlConnection con = new NpgsqlConnection(ConnectionString.connectionString);
        public DataSet getTour()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM public.\"Tour\"";
            
            
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);

            adapter.Fill(data);



            return data;
        }

        public bool themTour(DTO_Tour tour)
        {
            try
            {
                con.Open();

                string sql = string.Format("insert into Tour(matour, tentour) values ('{0}', '{1}')", tour.matour, tour.tentour);

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch(Exception)
            {
            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool suaTour(DTO_Tour tour)
        {
            try
            {
                con.Open();

                string sql = string.Format("Update Tour set tentour ='{1}' where matour = {2}", tour.tentour, tour.matour);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool xoaTour(int matour)
        {
            try
            {
                con.Open();

                string sql = string.Format("Delete from public.\"Tour\" where matour = {0}", matour);

                NpgsqlCommand command = new NpgsqlCommand(sql, con);

                if (command.ExecuteNonQuery() > 0)
                    return true;

               
            } catch(Exception )
            {
            }
            finally
            {
                con.Close();
            }

            return false;
        }
    }
}
